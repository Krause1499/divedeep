using Azure;
using DiveDeep.Data;
using DiveDeep.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;

namespace DiveDeep.Controllers
{
    // DTO til klienten (flatpickr kan læse { from: "...", to: "..." })
    public record DisabledRange(string from, string to);

    [ApiController]
    [Route("availability")]
    public class AvailabilityController : ControllerBase
    {
        private readonly DiveDeepContext _ctx;
        public AvailabilityController(DiveDeepContext ctx) => _ctx = ctx;

        public record DisabledRange(string from, string to);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisabledRange>>> Get(
            [FromQuery] int productId,
            [FromQuery] Size? size,
            [FromQuery] Gender? gender)
        {
            var s = size ?? Size.NA;
            var g = gender ?? Gender.NA;

            // Find enheden for varianten (brug FirstOrDefaultAsync og nullable int?)
            var unitId = await _ctx.InventoryUnits
                .Where(u => u.ProductId == productId && u.Size == s && u.Gender == g)
                .Select(u => (int?)u.Id)
                .FirstOrDefaultAsync();

            if (unitId == null)
                return Ok(Array.Empty<DisabledRange>()); // ingen bookinger endnu

            // Hent kun rækker med udfyldte datoer og projicér til non-nullables
            var raw = await _ctx.OrderItems
                .Where(oi => oi.InventoryUnitId == unitId.Value)
                .Where(oi => oi.Order.IsConfirmed == true)
                .Where(oi => oi.StartDate != null && oi.EndDate != null)
                .Select(oi => new {
                    Start = oi.StartDate!.Value,
                    End = oi.EndDate!.Value        // End er eksklusiv i din domænelogik
                })
                .OrderBy(x => x.Start)
                .ToListAsync();

            // Merge overlappende/tilstødende intervaller til pænere UI
            var merged = new List<(DateOnly Start, DateOnly End)>();
            foreach (var cur in raw)
            {
                if (merged.Count == 0)
                {
                    merged.Add((cur.Start, cur.End));
                    continue;
                }

                var lastIndex = merged.Count - 1;
                var last = merged[lastIndex];

                // Overlap eller tilstødende: last.End >= cur.Start
                if (last.End >= cur.Start)
                {
                    if (cur.End > last.End)
                        merged[lastIndex] = (last.Start, cur.End);
                }
                else
                {
                    merged.Add((cur.Start, cur.End));
                }
            }

            // flatpickr's ranges er inklusive → vis End-1 dag
            var result = merged.Select(m => new DisabledRange(
                from: m.Start.ToString("yyyy-MM-dd"),
                to: m.End.AddDays(-1).ToString("yyyy-MM-dd")
            ));

            // (valgfrit) kort caching
            Response.Headers["Cache-Control"] = "public, max-age=30";
            return Ok(result);
        }
    }

}

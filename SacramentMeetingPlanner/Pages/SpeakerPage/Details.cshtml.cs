﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.SpeakerPage
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

      public Speaker Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Speaker == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker.FirstOrDefaultAsync(m => m.id == id);
            if (speaker == null)
            {
                return NotFound();
            }
            else 
            {
                Speaker = speaker;
            }
            return Page();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructrue;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ResController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{BkgNumber}")]
        public ReservationDto Get(int BkgNumber)
        {
            return _reservationService.GetResByBkgNumber(BkgNumber);
        }
    }
}

using AutoMapper;
using AutoMapper.Configuration;
using BarterAppSolution.API.Dto;
using BarterAppSolution.API.Filters;
using BarterAppSolution.API.Helpers;
using BarterAppSolution.API.Models;
using BarterAppSolution.Core.Entity;
using BarterAppSolution.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Controllers
{
    //[ServiceFilter(typeof(LogFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationDataService locationDataService;
        public LocationController(ILocationDataService locationDataService)
        {
            this.locationDataService = locationDataService;
        }

        [HttpPost("AddNewLocationData")]
        [ProducesResponseType(typeof(ServiceResult<int>), StatusCodes.Status200OK)]
        public IActionResult InsertLocationData([FromBody] AddLocationDataDto addLocationDataDto)
        {
            LocationData locationData = new LocationData();

            locationData.Latitude = addLocationDataDto.latitude;
            locationData.Longitude = addLocationDataDto.longitude;
            locationData.AddressInfo = addLocationDataDto.address;
            locationData.Explanation = addLocationDataDto.explanation;
            locationData.AppState = addLocationDataDto.app_state;
            locationData.ServiceTitle = addLocationDataDto.service_title;
            locationData.DeviceTitle = addLocationDataDto.device_title;
            locationData.DeviceMac = addLocationDataDto.device_mac;

            locationData = locationDataService.Add(locationData);

            if (locationData != null && locationData.Id > 0)
            {
                HttpStatusCode status = HttpStatusCode.Created;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, true, locationData.Id));
            }
            else
            {
                HttpStatusCode status = HttpStatusCode.BadRequest;
                return StatusCode((int)status, Utils.GenerateServiceResult(status, false));
            }
        }

        [HttpGet("GetAllLocationData")]
        [ProducesResponseType(typeof(ServiceResult<List<LocationData>>), StatusCodes.Status200OK)]
        public IActionResult GetAllLocationData()
        {
            List<LocationData> locationData = locationDataService.GetAll().ToList();

            HttpStatusCode status = HttpStatusCode.OK;
            return StatusCode((int)status, Utils.GenerateServiceResult(status, true, locationData));
        }
    }
}

using HealthCareEasyApi.Models;
using HealthCareEasyApi.Dtos;
using HealthCareEasyApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace HealthCareEasyApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenhvienController : ControllerBase
    {
        private readonly HCEDbContext _context;
        private readonly IMapper _mapper;
        public BenhvienController(HCEDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<BenhvienDTO>>> GetBenhvienDetail()
        {

            //var resutl = await (from table in _context.Benhvien select table).ToListAsync();
            var resutl = await (from benhvien in _context.Benhvien
                          join dichvu in _context.Dichvu on benhvien.DichvuId equals dichvu.DichvuId
                          select new
                          {
                              benhvien_Id = benhvien.Benhvien_Id,
                              tenbenhvien = benhvien.Tenbenhvien,
                              thongtin = benhvien.Thongtin,
                              giatien = benhvien.Giatien,
                              image = benhvien.Image,
                              dichvuId = dichvu.DichvuId,
                              tendichvu = dichvu.Tendichvu
                          }
                          ).ToListAsync();
            var sub = _mapper.Map<Benhvien>(resutl[0]);
            var data = _mapper.Map<BenhvienDTO>(sub);
            return Ok(data);
        }
    }
}

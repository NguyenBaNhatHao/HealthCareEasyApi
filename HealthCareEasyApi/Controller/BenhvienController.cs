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
        public async Task<ActionResult<List<BenhvienDTO>>> GetBenhvien()
        {
            List<BenhvienDTO> BvDTOs = new List<BenhvienDTO>();
            var result = await (from benhvien in _context.Benhvien
                                join dichvu in _context.Dichvu on benhvien.DichvuId equals dichvu.DichvuId
                                select new
                                {
                                    benhvien_Id = benhvien.Benhvien_Id,
                                    tenbenhvien = benhvien.Tenbenhvien,
                                    thongtin = benhvien.Thongtin,
                                    giatien = benhvien.Giatien,
                                    image = benhvien.Image,
                                    dichvuId = benhvien.DichvuId,
                                    dichvu = benhvien.Dichvu
                                }
                          ).ToListAsync();
            foreach (var item in result)
            {
                BenhvienDTO bvdto = new BenhvienDTO();
                bvdto.Benhvien_Id = item.benhvien_Id;
                bvdto.Tenbenhvien = item.tenbenhvien;
                bvdto.dichvu = item.dichvu;
                bvdto.DichvuId = item.dichvuId;
                bvdto.Thongtin = item.thongtin;
                bvdto.Giatien = item.giatien;
                bvdto.Image = item.image;
                BvDTOs.Add(bvdto);
            }
            if (BvDTOs != null)
                return Ok(BvDTOs);
            else
                return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<BenhvienDTO>> CreateBenhvienDetail()
        {

            return null;
        }
        [HttpGet("detail")]
        public async Task<ActionResult<List<BenhvienDTO>>> GetBenhvienDetail()
        {
            List<BenhvienDTO> BvDTOs = new List<BenhvienDTO>();
            var result = await (from benhvien in _context.Benhvien
                                join dichvu in _context.Dichvu on benhvien.DichvuId equals dichvu.DichvuId
                                select new
                                {
                                    benhvien_Id = benhvien.Benhvien_Id,
                                    tenbenhvien = benhvien.Tenbenhvien,
                                    thongtin = benhvien.Thongtin,
                                    giatien = benhvien.Giatien,
                                    image = benhvien.Image,
                                    dichvuId = benhvien.DichvuId,
                                    dichvu = benhvien.Dichvu
                                }
                          ).ToListAsync();
            foreach(var item in result)
            {
                BenhvienDTO bvdto = new BenhvienDTO();
                bvdto.Benhvien_Id = item.benhvien_Id;
                bvdto.Tenbenhvien = item.tenbenhvien;
                bvdto.dichvu = item.dichvu;
                bvdto.DichvuId = item.dichvuId;
                bvdto.Thongtin = item.thongtin;
                bvdto.Giatien = item.giatien;
                bvdto.Image = item.image;
                BvDTOs.Add(bvdto);
            }
            if (BvDTOs != null)
                return Ok(BvDTOs);
            else
                return NotFound();
        }
    }
}

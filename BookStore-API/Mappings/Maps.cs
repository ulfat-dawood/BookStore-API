using AutoMapper;
using BookStore_API.Data;
using BookStore_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            //Declare your mappings
            //Mapping can go in either direction
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Author, AuthorDTO>().ReverseMap();
        }
    }
}

using BibliotecaMVC.Services.DTOs;
using BibliotecaMVC.Models;
using AutoMapper;
using static System.Reflection.Metadata.BlobBuilder;

namespace BibliotecaMVC.Profiles
{
    public class BooksProfile: Profile
    {
        public BooksProfile() {
            CreateMap<BooksViewModel, BooksDTO>().ReverseMap();
        }
    }
}

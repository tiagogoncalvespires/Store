namespace Store.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using Store.Web.Data.Entities;
    

    [Display(Name = "Image")]
    public class ProductViewModel : Product
    {
        public IFormFile ImageFile { get; set; }
    }

}

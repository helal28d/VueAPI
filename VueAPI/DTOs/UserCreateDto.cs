namespace VueAPI.DTOs
{
    public record struct UserCreateDto(
        string FirstName,
        string LastName,
        string Email,
        int Phone,
        string Password,
       List<ProductCreateDto> Products);
   
}



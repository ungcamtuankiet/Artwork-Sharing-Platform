namespace be_artwork_sharing_platform.Core.Dtos.Auth
{
    public class LoginServiceResponceDto
    {
        public string NewToken { get; set; }

        //This would be returned to front-end
        public UserInfoResult UserInfo { get; set; }
    }
}

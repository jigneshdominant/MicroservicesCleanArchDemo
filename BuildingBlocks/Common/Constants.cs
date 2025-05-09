namespace BuildingBlocks.Common
{
    public static class Constants
    {
        public const string DefaultIssuer = "MyMicroservicesIssuer";
        public const string DefaultAudience = "MyMicroservicesAudience";
        public const string JwtKey = "MyMicroserviceSecretKey@12345"; // move to secure store in production
    }
}
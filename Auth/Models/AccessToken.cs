namespace Auth.Models
{
    public class AccessToken
    {
        public string LiteralToken;
        public long IssuedAt;
        public long ExpiresAt;
        public string ClientId;
        public string UserId;
        public string ScopeId; 
    }
}
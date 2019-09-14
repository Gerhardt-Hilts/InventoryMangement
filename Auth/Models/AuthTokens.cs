using Microsoft.Win32.SafeHandles;

namespace Auth.Models
{
    public struct AuthTokens
    {
        public string accessToken;
        public string refreshToken;

        public AuthTokens(string inputAccessToken, string inputRefreshToken)
        {
            accessToken = inputAccessToken;
            refreshToken = inputRefreshToken;
        }
    }
}
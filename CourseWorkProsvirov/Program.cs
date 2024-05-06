namespace CourseWorkProsvirov
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static Roles ActiveRole;

        public static Roles getRole()
        {
            return ActiveRole;
        }

        public static void setRole(Roles role)
        {
            ActiveRole = role;
        }

        private static AuthenticatedUser authenticatedUser;

        public static AuthenticatedUser getAuthenticatedUser()
        {
            return authenticatedUser;
        }

        public static void setAuthenticatedUser(AuthenticatedUser authenticatedUserP)
        {
            authenticatedUser = authenticatedUserP;
        }

        private static UserAuthorization userAuthorization;

        public static UserAuthorization getUserAuthorization()
        {
            return userAuthorization;
        }

        public static void setUserAuthorization(UserAuthorization userAuthorizationP)
        {
            userAuthorization = userAuthorizationP;
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SigInUpForm());
        }
    }
}
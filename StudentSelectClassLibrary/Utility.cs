namespace StudentSelectClassLibrary
{
    public static class Utility
    {
        #region 权限

        public static string permission1 = "RESETPASSWORD"; // 重置密码权限

        #endregion

        #region 类型
        public const string type1 = "User";
        public const string type2 = "Admin";

        /// <summary>
        /// 登录类型翻译
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string TranslateType(string type)
        {
            switch (type)
            {
                case type1:
                    return "学生";
                case type2:
                    return "老师";
                default:
                    return "学生";
            }
        }

        #endregion
    }
}

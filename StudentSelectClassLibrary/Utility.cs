using System;
using System.Text;

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

        #region 金额小写转大写

        public static decimal? ParseToDecimalValue(object decimalObj)
        {
            if (decimalObj == null) return null;
            if (!decimal.TryParse(decimalObj.ToString(), out decimal decValue)) return null;
            return decValue;
        }

        /// <summary>
        /// 转中文大写数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConvertNumToZHUpperCase(decimal value)
        {
            string[] numList = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            string[] unitList = { "分", "角", "元", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟" };
            decimal money = value;
            if (money == 0)
            {
                return "零元整";
            }

            StringBuilder strMoney = new StringBuilder();
            //只取小数后2位
            string strNum = decimal.Truncate(money * 100).ToString();
            int len = strNum.Length;
            int zero = 0;
            for (int i = 0; i < len; i++)
            {
                int num = int.Parse(strNum.Substring(i, 1));
                int unitNum = len - i - 1;

                if (num == 0)
                {
                    zero++;
                    if (unitNum == 2 || unitNum == 6 || unitNum == 10)
                    {
                        if (unitNum == 2 || zero < 4)
                            strMoney.Append(unitList[unitNum]);
                        zero = 0;
                    }
                }
                else
                {

                    if (zero > 0)
                    {
                        strMoney.Append(numList[0]);
                        zero = 0;
                    }
                    strMoney.Append(numList[num]);
                    strMoney.Append(unitList[unitNum]);
                }

            }
            if (zero > 0)
                strMoney.Append("整");

            return strMoney.ToString();
        }

        /// <summary>
        /// 截取指定位数
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static decimal ToFixed(decimal d, int s)
        {
            decimal sp = Convert.ToDecimal(Math.Pow(10, s));
            return Math.Truncate(d) + Math.Floor((d - Math.Truncate(d)) * sp) / sp;
        }

        /// <summary>
        ///  截取指定位数
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double ToFixed(double d, int s)
        {
            double sp = Math.Pow(10, s);
            return Math.Truncate(d) + Math.Floor((d - Math.Truncate(d)) * sp) / sp;
        }

        #endregion
    }
}

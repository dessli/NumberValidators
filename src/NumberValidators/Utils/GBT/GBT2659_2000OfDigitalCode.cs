﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberValidators.Utils.GBT
{
    /// <summary>
    /// 世界各国和地区名称代码 （GB/T 2659-2000）
    /// </summary>
    public class GBT2659_2000OfDigitalCode : IValidationDictionary<string, NationCode>
    {
        private GBT2659_2000OfDigitalCode() { }
        /// <summary>
        /// 单例
        /// </summary>
        public static readonly GBT2659_2000OfDigitalCode Singleton = new GBT2659_2000OfDigitalCode();
        /// <summary>
        /// 基础数据字典
        /// </summary>
        private Dictionary<string, NationCode> Dictionary;
        private static object _lockObj = new object();
        /// <summary>
        /// 获取字典
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, NationCode> GetDictionary()
        {
            if (Dictionary == null)
            {
                lock (_lockObj)
                {
                    if (Dictionary == null)
                    {
                        Dictionary = NationCode.NationCodes.Value.ToDictionary(c => c.DigitalCode, c => c);
                    }
                }
            }
            return Dictionary;
        }
    }
}

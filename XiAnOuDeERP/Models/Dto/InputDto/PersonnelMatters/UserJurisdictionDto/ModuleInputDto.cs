﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XiAnOuDeERP.Models.Dto.InputDto.PersonnelMatters.UserJurisdictionDto
{
    /// <summary>
    /// 模块输入类
    /// </summary>
    public class ModuleInputDto
    {
        /// <summary>
        /// 模块Id
        /// </summary>
        public long ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 模块键
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
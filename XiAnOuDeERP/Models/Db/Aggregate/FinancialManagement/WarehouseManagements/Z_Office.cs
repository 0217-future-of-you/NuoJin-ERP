﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.ApprovalMangement;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.WarehouseManagements
{
    /// <summary>
    /// 办公用品耗材表
    /// </summary>
    [Table("Z_Office")]
    public class Z_Office : EntityBase
    {

        #region 通用字段

        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [StringLength(20)]
        public string Encoding { get; set; }
        /// <summary>
        /// 录入人Id
        /// </summary>
        public long EntryPersonId { get; set; }

        /// <summary>
        /// 入库类型
        /// </summary>
        public long? WarehousingTypeId { get; set; }

        /// <summary>
        /// 物料类别
        /// </summary>
        [StringLength(255)]
        public string RawMaterialType { get; set; }

        /// <summary>
        /// 单位Id
        /// </summary>
        public long? CompanyId { get; set; }

        /// <summary>
        /// 备注描述
        /// </summary>
        [StringLength(255)]
        public string Desc { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }


        /// <summary>
        /// 自身类型id
        /// </summary>
        public long Z_OfficeTypeid { get; set; }
        /// <summary>
        /// 录入人
        /// </summary>
        public  UserDetails EntryPerson { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public virtual Company Company { get; set; }
        /// <summary>
        /// 自身库类型
        /// </summary>
        public virtual WarehousingType WarehousingType { get; set; }
        /// <summary>
        /// 办公耗材用品类型
        /// </summary>
        public virtual Z_OfficeType Z_OfficeType { get; set; }

        #endregion

        #region 原材料字段

        /// <summary>
        /// 英文名称
        /// </summary>
        [StringLength(255)]
        public string EnglishName { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        [StringLength(255)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// 俗称1
        /// </summary>
        [StringLength(255)]
        public string BeCommonlyCalled1 { get; set; }

        /// <summary>
        /// 俗称2
        /// </summary>
        public string BeCommonlyCalled2 { get; set; }

        /// <summary>
        /// CAS号
        /// </summary>
        [StringLength(255)]
        public string CASNumber { get; set; }

        /// <summary>
        /// 分子量
        /// </summary>
        [StringLength(255)]
        public string MolecularWeight { get; set; }

        /// <summary>
        /// 分子式
        /// </summary>
        [StringLength(255)]
        public string MolecularFormula { get; set; }

        /// <summary>
        /// 结构式
        /// </summary>
        [StringLength(255)]
        public string StructuralFormula { get; set; }

        /// <summary>
        /// 外观状态
        /// </summary>
        [StringLength(255)]
        public string AppearanceState { get; set; }
        /// <summary>
        /// 密度
        /// </summary>
        [StringLength(100)]
        public string Density { get; set; }

        /// <summary>
        /// 危害声明
        /// </summary>
        [StringLength(100)]
        public string Statement { get; set; }


        /// <summary>
        /// 警示声明
        /// </summary>
        [StringLength(100)]
        public string Caution { get; set; }

        #endregion

        #region 科研耗材字段

        #endregion

        #region 办公用品字段

        #endregion

        #region 设备字段

        /// <summary>
        /// 使用年限
        /// </summary>
        //public double? ServiceLife { get; set; }

        ///// <summary>
        ///// 技术说明
        ///// </summary>
        //[StringLength(255)]
        //public string TechnicalDescription { get; set; }

        #endregion










    }
}
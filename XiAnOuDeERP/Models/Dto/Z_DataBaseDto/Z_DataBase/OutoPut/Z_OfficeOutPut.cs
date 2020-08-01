﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.ApprovalMangement;
using XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.WarehouseManagements;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Dto.Z_DataBaseDto.Z_DataBase.OutoPut
{
    public class Z_OfficeOutPut : InputBase
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 查询
        /// </summary>
        public long Ids { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 公司自己的编码
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// 录入人Id
        /// </summary>
        public long EntryPersonId { get; set; }

        /// <summary>
        /// 录入人
        /// </summary>
        public string EntryPersonName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string RowtypeName { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string WarehousingTypeName { get; set; }
        /// <summary>
        /// 物料备注
        /// </summary>

        public string Desc { get; set; }
        /// <summary>
        /// 数量
        /// </summary>

        public double? Number { get; set; }
        /// <summary>
        /// 原材料类型
        /// </summary>
        public string Z_OfficeTypeid { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; } = false;


        /// <summary>
        /// 英文名称
        /// </summary>

        public string EnglishName { get; set; }

        /// <summary>
        /// 简称
        /// </summary>

        public string Abbreviation { get; set; }

        /// <summary>
        /// 俗称1
        /// </summary>

        public string BeCommonlyCalled1 { get; set; }

        /// <summary>
        /// 俗称2
        /// </summary>
        public string BeCommonlyCalled2 { get; set; }

        /// <summary>
        /// CAS号
        /// </summary>

        public string CASNumber { get; set; }

        /// <summary>
        /// 分子量
        /// </summary>

        public string MolecularWeight { get; set; }

        /// <summary>
        /// 分子式
        /// </summary>

        public string MolecularFormula { get; set; }

        /// <summary>
        /// 结构式
        /// </summary>

        public string StructuralFormula { get; set; }
        /// <summary>
        /// 密度
        /// </summary>
        public string Density { get; set; }

        /// <summary>
        /// 危害声明
        /// </summary>

        public string Statement { get; set; }


        /// <summary>
        /// 警示声明
        /// </summary>

        public string Caution { get; set; }

        /// <summary>
        /// 外观状态
        /// </summary>

        public string AppearanceState { get; set; }


        /// <summary>
        /// 入库类型
        /// </summary>
        public string WarehousingTypeId { get; set; }


        /// <summary>
        /// 录入人
        /// </summary>
        public UserDetails EntryPerson { get; set; }


        /// <summary>
        /// 单位
        /// </summary>
        public Company Company { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Companyid { get; set; }


        /// <summary>
        /// 自身类型
        /// </summary>
        public Z_OfficeType Z_OfficeType { get; set; }



        /// <summary>
        /// 出入库类型
        /// </summary>
        public WarehousingType WarehousingType { get; set; }

        public DateTime CreateDate { get; set; }



    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using XiAnOuDeERP.Models.Db.Aggregate.PersonnelMatters.Users;
using XiAnOuDeERP.Models.Util;

namespace XiAnOuDeERP.Models.Db.Aggregate.FinancialManagement.WageManagements
{
    /// <summary>
    /// 工资实体类
    /// </summary>
    [Table("Wage")]
    public class Wage : EntityBase
    {
        /// <summary>
        /// 收款人Id
        /// </summary>
        [Required]
        public long UserId { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 基本工资
        /// </summary>
        public decimal BasePay { get; set; }

        /// <summary>
        /// 岗位工资
        /// </summary>
        public decimal PostSalary { get; set; }

        /// <summary>
        /// 绩效工资
        /// </summary>
        public decimal MeritPay { get; set; }

        /// <summary>
        /// 保密工资
        /// </summary>
        public decimal ConfidentialSalary { get; set; }

        /// <summary>
        /// 工龄工资
        /// </summary>
        public decimal SeniorityPay { get; set; }

        /// <summary>
        /// 学历工资
        /// </summary>
        public decimal EducationSalary { get; set; }

        /// <summary>
        /// 交通餐补
        /// </summary>
        public decimal TrafficAndMealSupplement { get; set; }

        /// <summary>
        /// 奖金实发
        /// </summary>
        public decimal BonusPaidIn { get; set; }

        /// <summary>
        /// 加(夜)班费用
        /// </summary>
        public decimal OvertimeExpenses { get; set; }

        /// <summary>
        /// 全勤奖
        /// </summary>
        public decimal TotalManagementSystem { get; set; }

        /// <summary>
        /// 应付工资
        /// </summary>
        public decimal WagesPayable { get; set; }

        /// <summary>
        /// 养老保险
        /// </summary>
        public decimal EndowmentInsurance { get; set; }

        /// <summary>
        /// 医疗保险
        /// </summary>
        public decimal MedicalInsurance { get; set; }

        /// <summary>
        /// 大额保险
        /// </summary>
        public decimal LargeInsurance { get; set; }

        /// <summary>
        /// 失业保险
        /// </summary>
        public decimal UnemploymentInsurance { get; set; }

        /// <summary>
        /// 税前工资
        /// </summary>
        public decimal GrossPay { get; set; }

        /// <summary>
        /// 应扣税
        /// </summary>
        public decimal TaxDeductible { get; set; }

        /// <summary>
        /// 实付工资
        /// </summary>
        public decimal PaidWages { get; set; }

        /// <summary>
        /// 签字Id
        /// </summary>
        public long? SignId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(255)]
        public string Desc { get; set; }

        /// <summary>
        /// 其他工资总和
        /// </summary>
        public decimal OtherSum { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 签字人
        /// </summary>
        public virtual UserDetails Sign { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        public virtual UserDetails User { get; set; }
    }
}
#region ● Namespace declaration

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Web.Services.Protocols;

using Microsoft.Practices.CompositeUI.SmartParts;

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

using Bizentro.AppFramework.UI.Controls;
using Bizentro.AppFramework.UI.Module;
using Bizentro.AppFramework.UI.Variables;
using Bizentro.AppFramework.DataBridge;

#endregion

namespace Bizentro.App.UI.FI.F2316MA2_CKO166
{
    [SmartPart]
    public partial class ModuleViewer : ViewBase
    {

        #region ▶ 1. Declaration part

        #region ■ 1.1 Program information
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   This part describe the summary information about class 
        /// </Desc>
        /// <History>⑤
        ///   <FirstCreated>
        ///     <history name="creator" Date="created date">Make …</history>
        ///   </FirstCreated>
        ///   <Lastmodified>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///   </Lastmodified>
        /// </History>
        /// <Remarks>⑥
        ///   <remark name="modifier"  Date="modified date">… </remark>
        ///   <remark name="modifier"  Date="modified date">… </remark>
        /// </Remarks>

        #endregion

        #region ■ 1.2. Class global constants (common)

        #endregion

        #region ■ 1.3. Class global variables (common)

        #endregion

        #region ■ 1.4 Class global constants (grid)

        #endregion

        #region ■ 1.5 Class global variables (grid)
        private tdsF2316MA1 cqtdsF2316MA1 = new tdsF2316MA1();

        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)

        public ModuleViewer()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)

        protected override void Form_Load()
        {

            uniBase.UCommon.SetViewType(enumDef.ViewType.T02_Multi);

            uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Query, enumDef.ModuleInformation.FinancialAccounting);  // Load company numeric format. I: Input Program, *: All Module
            this.LoadCustomInfTB19029();                                                   // Load custoqm numeric format

        }

        protected override void Form_Load_Completed()
        {
            //DBQuery();
            //ControlName.Focus();                // Set focus
        }

        #endregion

        #region ■ 2.3 Initializatize local global variables

        protected override void InitLocalVariables()
        {

        }

        #endregion

        #region ■ 2.4 Set local global default variables

        protected override void SetLocalDefaultValue()
        {
            // Assign default value to controls
            //dtBdgYymmFr.uniDateTimeF.Value = DateTime.Now.AddDays(1 - DateTime.Today.Day);
            //dtBdgYymmFr.uniDateTimeT.Value = DateTime.Now;
            this.cboBdgCtrlUnit.Value = "M";

            dtBdgYymm.uniDateTimeF.Value = DateTime.Now.AddDays(1 - DateTime.Today.Day);
            dtBdgYymm.uniDateTimeT.Value = DateTime.Now;

            string sql = string.Format(@"
            select top 1 org_change_id , b.ORGNM +' ('+ ORGDT + ')'  
            --,convert(datetime, convert(varchar(6), getdate() ,112) + '01') yyyymm1
            --,convert(datetime, convert(varchar(6), getdate() ,112) + '01') yyyymm2
            ,convert(datetime, convert(varchar(4), getdate() ,112) + '0101') yyyymm1
            ,convert(datetime, convert(varchar(4), getdate() ,112) + '1231') yyyymm2
            from b_acct_dept a join horg_abs b on a.org_change_id = b.ORGID
            where org_change_dt in (
            select max(org_change_dt) from b_acct_dept a
            where org_change_dt <= getdate() ) ");

            DataSet dsSql = uniBase.UDataAccess.CommonQuerySQL(sql);

            if (dsSql.Tables[0].Rows.Count > 0)
            {
                popOrgId.CodeValue = dsSql.Tables[0].Rows[0]["org_change_id"].ToString();
                popOrgId.RetrieveNameValue();
                dtBdgYymm.uniDateTimeF.Value = dsSql.Tables[0].Rows[0]["yyyymm1"];
                dtBdgYymm.uniDateTimeT.Value = dsSql.Tables[0].Rows[0]["yyyymm2"];
            }

                       
            //         if (CommonVariable.gDepart == "")
            //         {

            //             string strSQL = string.Format("select b.org_cd,dept.dept_cd, dept.dept_nm, dept.ORG_CHANGE_ID  from Z_USR_MAST_REC a(nolock) inner join dbo.UFN_H_GETDEPTDATA_CKO166('') dept on dept.emp_no = a.INTERFACE_ID  left join f_bdg_org_dept b (nolock) on dept.ORG_CHANGE_ID = b.ORG_CHANGE_ID and dept.dept_cd = b.dept_cd and b.bdg_ctrl_org not in ('01', '99') where a.USR_KIND = 'U' and a.USR_ID = {0}",
            //uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true));

            //             DataSet dsDept = uniBase.UDataAccess.CommonQuerySQL(strSQL);

            //             if (dsDept == null || dsDept.Tables[0].Rows.Count == 0)
            //             {
            //                 popORG_CD.CodeValue = "";
            //                 popORG_CD.CodeName = "";

            //             }
            //             else
            //             {
            //                 popORG_CD.CodeValue = dsDept.Tables[0].Rows[0]["org_cd"].ToString();
            //                 popORG_CD.RetrieveNameValue();
            //                 string BDGMASTER = string.Empty;
            //                 string strSql = string.Empty;
            //                 strSql = string.Format(@"
            //                                             select *from Z_USR_MAST_REC_USR_ROLE_ASSO
            //                                             where USR_ID ={0}
            //                                               and USR_ROLE_ID = 'BDGMASTER'
            //                                             ", uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true));

            //                 DataSet dsROLE = uniBase.UDataAccess.CommonQuerySQL(strSql);

            //                 if (dsROLE != null && dsROLE.Tables.Count > 0 && dsROLE.Tables[0].Rows.Count > 0)
            //                 {
            //                     uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Normal);
            //                     popORG_CD.FieldType = enumDef.FieldType.Default;
            //                 }
            //                 else
            //                 {
            //                     uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Protected);
            //                     popORG_CD.FieldType = enumDef.FieldType.ReadOnly;

            //                 }


            //             }
            //         }
            //         else
            //         {

            //             string sDEPT_CD = CommonVariable.gDepart;
            //             string strDeptQuery = string.Format(@"
            //         SELECT b.org_cd ,DEPT.DEPT_CD, DEPT.DEPT_NM
            //         from DBO.UFN_H_GETDEPTDATA_CKO166('') DEPT 
            //         left join f_bdg_org_dept b (nolock) on dept.ORG_CHANGE_ID = b.ORG_CHANGE_ID and dept.dept_cd = b.dept_cd and b.bdg_ctrl_org not in ('01', '99') where
            //          DEPT.DEPT_CD = '{0}'
            //         "
            //   , sDEPT_CD.ToString()


            //   );

            //             try
            //             {
            //                 DataSet ds = uniBase.UDataAccess.CommonQuerySQL(strDeptQuery);

            //                 if (ds == null || ds.Tables == null || ds.Tables[0].Rows.Count <= 0)
            //                 {
            //                     return;
            //                 }

            //                 popORG_CD.CodeValue = ds.Tables[0].Rows[0]["org_cd"].ToString();
            //                 popORG_CD.RetrieveNameValue();
            //                 string BDGMASTER = string.Empty;
            //                 string strSql = string.Empty;
            //                 strSql = string.Format(@"
            //                                             select *from Z_USR_MAST_REC_USR_ROLE_ASSO
            //                                             where USR_ID ={0}
            //                                               and USR_ROLE_ID = 'BDGMASTER'
            //                                             ", uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true));

            //                 DataSet dsROLE = uniBase.UDataAccess.CommonQuerySQL(strSql);

            //                 if (dsROLE != null && dsROLE.Tables.Count > 0 && dsROLE.Tables[0].Rows.Count > 0)
            //                 {
            //                     uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Normal);
            //                     popORG_CD.FieldType = enumDef.FieldType.Default;
            //                 }
            //                 else
            //                 {
            //                     uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Protected);
            //                     popORG_CD.FieldType = enumDef.FieldType.ReadOnly;

            //                 }

            //             }
            //             catch (Exception)
            //             {

            //             }

            //         }

            //2023-09-14변경 부서정보
            string strSQL = string.Format("select b.ORG_CD,dept.child_dept_cd dept_cd, dept.child_dept_nm dept_nm,dept.org_change_id " +
                                            "from Z_USR_ORG_MAST a(nolock) " +
                                            "inner join dbo.ufn_GetDeptAcc(dbo.ufn_get_orgchange_id(convert(nvarchar(10), getdate(), 121))) dept on dept.child_dept_cd = a.ORG_CD " +
                                            "left join f_bdg_org_dept b (nolock) on dept.ORG_CHANGE_ID = b.ORG_CHANGE_ID and dept.child_dept_cd = b.dept_cd and b.bdg_ctrl_org not in ('01', '99') " +
                                            "where a.ORG_TYPE = 'DP' " +
                                            "and a.USR_ID = {0} " +
                                            "and a.USE_YN = 'Y' " +

                                            "select c.ORG_CD,dept.dept_cd, dept.dept_nm,b.org_change_id " +
                                            "from Z_USR_MAST_REC a(nolock) " +
                                            "inner join dbo.ufn_h_GetDeptData('') dept on dept.emp_no = a.INTERFACE_ID " +
                                            "inner join B_ACCT_DEPT b(nolock) on dept.dept_cd = b.DEPT_CD and b.ORG_CHANGE_DT = (select max(ORG_CHANGE_DT) from B_ACCT_DEPT (nolock)) " +
                                            "left join f_bdg_org_dept c (nolock) on b.ORG_CHANGE_ID = c.ORG_CHANGE_ID and dept.dept_cd = c.dept_cd and c.bdg_ctrl_org not in ('01', '99') "+
                                            "where a.USR_KIND = 'U' " +
                                            "and a.USR_ID = {0} ",
               uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true));

            DataSet dsDept = uniBase.UDataAccess.CommonQuerySQL(strSQL);

            if (dsDept == null)
            {
                popORG_CD.CodeValue = "";
                popORG_CD.CodeName = "";
                //hOrgChangeId = "";
            }
            else
            {
                if (dsDept.Tables[0].Rows.Count != 0)
                {
                    popORG_CD.CodeValue = dsDept.Tables[0].Rows[0]["ORG_CD"].ToString().Trim();
                    popORG_CD.RetrieveNameValue();
                    //hOrgChangeId = dsDept.Tables[0].Rows[0]["ORG_CHANGE_ID"].ToString();
                }
                else
                {
                    if (dsDept.Tables[1].Rows.Count != 0)
                    {
                        popORG_CD.CodeValue = dsDept.Tables[1].Rows[0]["ORG_CD"].ToString().Trim();
                        popORG_CD.RetrieveNameValue();
                        //hOrgChangeId = dsDept.Tables[1].Rows[0]["ORG_CHANGE_ID"].ToString();
                    }
                }

            }
            string BDGMASTER = string.Empty;
            string strSql = string.Empty;
            strSql = string.Format(@"
                                                select *from Z_USR_MAST_REC_USR_ROLE_ASSO
                                                where USR_ID ={0}
                                                  and USR_ROLE_ID = 'BDGMASTER'
                                                ", uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true));

            DataSet dsROLE = uniBase.UDataAccess.CommonQuerySQL(strSql);

            if (dsROLE != null && dsROLE.Tables.Count > 0 && dsROLE.Tables[0].Rows.Count > 0)
            {
                uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Normal);
                popORG_CD.FieldType = enumDef.FieldType.Default;
            }
            else
            {
                uniBase.UCommon.ChangeFieldLockAttribute(popORG_CD, enumDef.FieldLockAttribute.Protected);
                popORG_CD.FieldType = enumDef.FieldType.ReadOnly;

            }

            return;
        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData)

        protected override void GatheringComboData()
        {
            uniBase.UData.ComboMajorAdd("BDG_CTRL_ORG", "F2300"); //2015.08
            uniBase.UData.ComboMajorAdd("BDG_CTRL_UNIT", "F2010");

            this.cboBdgCtrlUnit.ComboMajorCd = "F2010";
            this.cboBdgCtrlUnit.AddEmptyRow = true;
        }
        #endregion

        #region ■ 2.6 Define user defined numeric info

        public void LoadCustomInfTB19029()
        {

            #region User Define Numeric Format Data Setting  ☆
            //base.viewTB19029.ggUserDefined6.DecPoint = 0;
            //base.viewTB19029.ggUserDefined6.Integeral = 15;
            #endregion
        }

        #endregion

        #endregion

        #region ▶ 3. Grid method part

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()
        {
            #region ■■ 3.1.1 Pre-setting grid information

            //wsMyBizFL.TypedDataSet.TableName tb = dsAnyNamy.TableName; 
            tdsF2316MA1.E_F_BDGNDataTable uniGridTB = cqtdsF2316MA1.E_F_BDGN;    //Grid 1

            uniGrid1.SSSetEdit(uniGridTB.bdg_yyyyColumn.ColumnName, "예산년도", enumDef.FieldType.ReadOnly, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(uniGridTB.org_change_idColumn.ColumnName, "부서개편ID", enumDef.FieldType.ReadOnly, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(uniGridTB.bdg_cdColumn.ColumnName, "예산", enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetEdit(uniGridTB.gp_acct_nmColumn.ColumnName, "예산명", 150, enumDef.FieldType.ReadOnly);
            //uniGrid1.SSSetEdit(uniGridTB.org_cdColumn.ColumnName, "통제그룹", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Upper, false, enumDef.HAlign.Left);
            //uniGrid1.SSSetEdit(uniGridTB.org_nmColumn.ColumnName, "통제그룹명", 120, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetEdit(uniGridTB.dept_cdColumn.ColumnName, "부서", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Upper, false, enumDef.HAlign.Left);
            uniGrid1.SSSetEdit(uniGridTB.dept_nmColumn.ColumnName, "부서명", 120, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetCombo(uniGridTB.bdg_ctrl_unitColumn.ColumnName, "통제", viewDataSet.Tables["bdg_ctrl_unit"], enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amttotColumn.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amttotColumn.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amttotColumn.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.MM_bdg_amttotColumn.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.MM_gl_amttotColumn.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.MM_bal_amttotColumn.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);


            uniGrid1.SSSetFloat(uniGridTB.bdg_amt1Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt1Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt1Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt2Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt2Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt2Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt3Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt3Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt3Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt4Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt4Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt4Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt5Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt5Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt5Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt6Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt6Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt6Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt7Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt7Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt7Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt8Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt8Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt8Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt9Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt9Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt9Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt10Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt10Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt10Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt11Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt11Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt11Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetFloat(uniGridTB.bdg_amt12Column.ColumnName, "예산", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.gl_amt12Column.ColumnName, "실적", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);
            uniGrid1.SSSetFloat(uniGridTB.bal_amt12Column.ColumnName, "잔액", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly);

            uniGrid1.SSSetDate(uniGridTB.bdg_dt1Column.ColumnName, "1월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt2Column.ColumnName, "2월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt3Column.ColumnName, "3월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt4Column.ColumnName, "4월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt5Column.ColumnName, "5월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt6Column.ColumnName, "6월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt7Column.ColumnName, "7월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt8Column.ColumnName, "8월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt9Column.ColumnName, "9월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt10Column.ColumnName, "10월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt11Column.ColumnName, "11월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB.bdg_dt12Column.ColumnName, "12월", 50, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYYMMDD, enumDef.HAlign.Center);

            #endregion

            #region ■■ 3.1.2 Formatting grid information

            uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.Yes);
            uniGrid1.DisplayLayout.Override.RowSizing = RowSizing.AutoFree;
            uniGrid1.SetMerge(uniGridTB.org_change_idColumn.ColumnName, 0, 0, 1, 2);
            uniGrid1.SetMerge(uniGridTB.bdg_cdColumn.ColumnName, 1, 0, 1, 2);
            uniGrid1.SetMerge(uniGridTB.gp_acct_nmColumn.ColumnName, 2, 0, 1, 2);
            uniGrid1.SetMerge(uniGridTB.dept_cdColumn.ColumnName, 3, 0, 1, 2);
            uniGrid1.SetMerge(uniGridTB.dept_nmColumn.ColumnName, 4, 0, 1, 2);
            uniGrid1.SetMerge(uniGridTB.bdg_ctrl_unitColumn.ColumnName, 5, 0, 1, 2);

            uniGrid1.SetMerge(uniGridTB.bdg_amttotColumn.ColumnName, 6, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amttotColumn.ColumnName, 7, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amttotColumn.ColumnName, 8, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.MM_bdg_amttotColumn.ColumnName, 9, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.MM_gl_amttotColumn.ColumnName, 10, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.MM_bal_amttotColumn.ColumnName, 11, 1, 1, 1);


            uniGrid1.SetMerge(uniGridTB.bdg_amt1Column.ColumnName, 12, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt1Column.ColumnName, 13, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt1Column.ColumnName, 14, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt2Column.ColumnName, 15, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt2Column.ColumnName, 16, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt2Column.ColumnName, 17, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt3Column.ColumnName, 18, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt3Column.ColumnName, 19, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt3Column.ColumnName, 20, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt4Column.ColumnName, 21, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt4Column.ColumnName, 22, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt4Column.ColumnName, 23, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt5Column.ColumnName, 24, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt5Column.ColumnName, 25, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt5Column.ColumnName, 26, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt6Column.ColumnName, 27, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt6Column.ColumnName, 28, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt6Column.ColumnName, 29, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt7Column.ColumnName, 30, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt7Column.ColumnName, 31, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt7Column.ColumnName, 32, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt8Column.ColumnName, 33, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt8Column.ColumnName, 34, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt8Column.ColumnName, 35, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt9Column.ColumnName, 36, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt9Column.ColumnName, 37, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt9Column.ColumnName, 38, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt10Column.ColumnName, 39, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt10Column.ColumnName, 40, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt10Column.ColumnName, 41, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt11Column.ColumnName, 42, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt11Column.ColumnName, 43, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt11Column.ColumnName, 44, 1, 1, 1);

            uniGrid1.SetMerge(uniGridTB.bdg_amt12Column.ColumnName, 45, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.gl_amt12Column.ColumnName, 46, 1, 1, 1);
            uniGrid1.SetMerge(uniGridTB.bal_amt12Column.ColumnName, 47, 1, 1, 1);

            UltraGridColumn col1 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("전체");
            uniGrid1.SetMerge("전체", 6, 0, 3, 1);
            col1.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col1_MM = uniGrid1.DisplayLayout.Bands[0].Columns.Add(dtBdgYymm.uniFromValue.Month.ToString() + "월 ~ " + dtBdgYymm.uniToValue.Month.ToString() + "월");
            uniGrid1.SetMerge(dtBdgYymm.uniFromValue.Month.ToString() + "월 ~ " + dtBdgYymm.uniToValue.Month.ToString() + "월", 9, 0, 3, 1);
            col1_MM.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;


            UltraGridColumn col2 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("1월");
            uniGrid1.SetMerge("1월", 12, 0, 3, 1);
            col2.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col3 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("2월");
            uniGrid1.SetMerge("2월", 15, 0, 3, 1);
            col3.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col4 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("3월");
            uniGrid1.SetMerge("3월", 18, 0, 3, 1);
            col4.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col5 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("4월");
            uniGrid1.SetMerge("4월", 21, 0, 3, 1);
            col5.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col6 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("5월");
            uniGrid1.SetMerge("5월", 24, 0, 3, 1);
            col6.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col7 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("6월");
            uniGrid1.SetMerge("6월", 27, 0, 3, 1);
            col7.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col8 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("7월");
            uniGrid1.SetMerge("7월", 30, 0, 3, 1);
            col8.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col9 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("8월");
            uniGrid1.SetMerge("8월", 33, 0, 3, 1);
            col9.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col10 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("9월");
            uniGrid1.SetMerge("9월", 36, 0, 3, 1);
            col10.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col11 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("10월");
            uniGrid1.SetMerge("10월", 39, 0, 3, 1);
            col11.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col12 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("11월");
            uniGrid1.SetMerge("11월", 42, 0, 3, 1);
            col12.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            UltraGridColumn col13 = uniGrid1.DisplayLayout.Bands[0].Columns.Add("12월");
            uniGrid1.SetMerge("12월", 45, 0, 3, 1);
            col13.RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;

            if (uniGrid1.DisplayLayout.Bands[0].Columns.Count > 0)
            {
                uniGrid1.DisplayLayout.Bands[0].Columns["org_change_id"].MergedCellStyle = MergedCellStyle.Always;
                uniGrid1.DisplayLayout.Bands[0].Columns["org_change_id"].MergedCellContentArea = MergedCellContentArea.VisibleRect;

                uniGrid1.DisplayLayout.Bands[0].Columns["bdg_cd"].MergedCellStyle = MergedCellStyle.Always;
                uniGrid1.DisplayLayout.Bands[0].Columns["bdg_cd"].MergedCellContentArea = MergedCellContentArea.VisibleRect;

                uniGrid1.DisplayLayout.Bands[0].Columns["gp_acct_nm"].MergedCellStyle = MergedCellStyle.Always;
                uniGrid1.DisplayLayout.Bands[0].Columns["gp_acct_nm"].MergedCellContentArea = MergedCellContentArea.VisibleRect;

                //uniGrid1.DisplayLayout.Bands[0].Columns["org_cd"].MergedCellStyle = MergedCellStyle.Always;
                //uniGrid1.DisplayLayout.Bands[0].Columns["org_cd"].MergedCellContentArea = MergedCellContentArea.VisibleRect;

                //uniGrid1.DisplayLayout.Bands[0].Columns["org_nm"].MergedCellStyle = MergedCellStyle.Always;
                //uniGrid1.DisplayLayout.Bands[0].Columns["org_nm"].MergedCellContentArea = MergedCellContentArea.VisibleRect;
            }

            #endregion

            #region ■■ 3.1.3 Setting etc grid

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amttotColumn.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amttotColumn.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amttotColumn.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt1Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt1Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt1Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt2Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt2Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt2Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt3Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt3Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt3Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt4Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt4Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt4Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt5Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt5Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt5Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt6Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt6Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt6Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt7Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt7Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt7Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt8Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt8Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt8Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt9Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt9Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt9Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt10Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt10Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt10Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt11Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt11Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt11Column.ColumnName, enumSummaryTypes.Sum);

            //this.uniGrid1.SetSummary(uniGridTB.bdg_amt12Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.gl_amt12Column.ColumnName, enumSummaryTypes.Sum);
            //this.uniGrid1.SetSummary(uniGridTB.bal_amt12Column.ColumnName, enumSummaryTypes.Sum);

            // Hidden Column Setting
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_yyyyColumn.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt1Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt2Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt3Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt4Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt5Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt6Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt7Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt8Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt9Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt10Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt11Column.ColumnName);
            this.uniGrid1.SSSetColHidden(uniGridTB.bdg_dt12Column.ColumnName);

            #endregion
        }
        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.
        }

        #endregion

        #region ■ 3.3 SetSpreadColor

        private void SetSpreadColor(int pvStartRow, int pvEndRow)
        {
            // TO-DO: InsertRow후 그리드 컬러 변경
            //uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
        }
        #endregion

        #region ■ 3.4 InitControlBinding
        protected override void InitControlBinding()
        {
            InitSpreadSheet();

            uniGrid1.uniGridSetDataBinding(cqtdsF2316MA1.E_F_BDGN);
        }
        #endregion

        #endregion

        #region ▶ 4. Toolbar method part

        #region ■ 4.1 Common Fnction group

        #region ■■ 4.1.1 OnFncQuery(old:FncQuery)

        protected override bool OnFncQuery()
        {

            if (dtBdgYymm.uniFromValue.Year.ToString() != dtBdgYymm.uniToValue.Year.ToString())
            {
                uniBase.UMessage.DisplayMessageBox("W70001", MessageBoxButtons.OK, "조회기간의 년도는 동일해야합니다.");
                return false;
            }

            return DBQuery();
        }

        #endregion

        #region ■■ 4.1.2 OnFncSave(old:FncSave)
        protected override bool OnFncSave()
        {
            //TO-DO : code business oriented logic
            return DBSave();
        }
        #endregion

        #endregion

        #region ■ 4.2 Single Fnction group

        #region ■■ 4.2.1 OnFncNew(old:FncNew)

        protected override bool OnFncNew()
        {

            //TO-DO : code business oriented logic

            return true;
        }

        #endregion

        #region ■■ 4.2.2 OnFncDelete(old:FncDelete)

        protected override bool OnFncDelete()
        {
            //TO-DO : code business oriented logic

            return true;
        }

        #endregion

        #region ■■ 4.2.3 OnFncCopy(old:FncCopy)

        protected override bool OnFncCopy()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.4 OnFncFirst(No implementation)

        #endregion

        #region ■■ 4.2.5 OnFncPrev(old:FncPrev)

        protected override bool OnFncPrev()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.6 OnFncNext(old:FncNext)

        protected override bool OnFncNext()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.7 OnFncLast(No implementation)

        #endregion

        #endregion

        #region ■ 4.3 Grid Fnction group

        #region ■■ 4.3.1 OnFncInsertRow(old:FncInsertRow)
        protected override bool OnFncInsertRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.2 OnFncDeleteRow(old:FncDeleteRow)
        protected override bool OnFncDeleteRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.3 OnFncCancel(old:FncCancel)
        protected override bool OnFncCancel()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.4 OnFncCopyRow(old:FncCopy)
        protected override bool OnFncCopyRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #endregion

        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {

            uniGrid1.ResetGrid();

            InitSpreadSheet();
            uniGrid1.ResetGrid();

            InitSpreadSheet();
            uniGrid1.uniGridSetDataBinding(cqtdsF2316MA1.E_F_BDGN);

            DataSet idataset = new DataSet();
            StringBuilder strSQL = new StringBuilder();

            string sBdgDt = string.Empty;
            string sBdgMMDt = string.Empty;
            string sBdgDtFr = string.Empty;
            string sBdgDtTo = string.Empty;
            string sOrgId = string.Empty;

            sBdgDt = dtBdgYymm.uniFromValue.Year.ToString();
            //sBdgMMDt = dtBdgYearMonth.uniValue.ToString(CommonVariable.CDT_YYYYMM);
            sBdgDtFr = Convert.ToDateTime(dtBdgYymm.uniFromValue).ToString(CommonVariable.CDT_YYYYMM);
            sBdgDtTo = Convert.ToDateTime(dtBdgYymm.uniToValue).ToString(CommonVariable.CDT_YYYYMM);
            sOrgId = this.popOrgId.CodeValue.ToString().Trim();


            try
            {
                uniCommand iuniCommand = uniBase.UDatabase.GetStoredProcCommand("USP_A_F2316MA2_CKO166_NEW");
                SqlDbType xCharType = uniBase.UDatabase.XCharType;
                SqlDbType xVarCharType = uniBase.UDatabase.XVarCharType;

                uniBase.UDatabase.AddInParameter(iuniCommand, "@ORG_CHANGE_ID", xVarCharType, sOrgId);
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_YYYY", xCharType, sBdgDt);
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_YYYYMM", xCharType, sBdgDtFr);
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_YYYYMM1", xCharType, sBdgDtTo);
                uniBase.UDatabase.AddInParameter(iuniCommand, "@ORG_CD", xVarCharType, popORG_CD.CodeValue.ToString());
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_CD_FR", xVarCharType, popBdgCdFr.CodeValue.ToString());
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_CD_TO", xVarCharType, popBdgCdTo.CodeValue.ToString());
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BDG_CTRL_UNIT", xCharType, cboBdgCtrlUnit.Value.ToString());
                uniBase.UDatabase.AddInParameter(iuniCommand, "@UserID", xCharType, CommonVariable.gUsrID.ToString());

                idataset = uniBase.UDatabase.ExecuteDataSet(iuniCommand);

                if (idataset == null || idataset.Tables[0].Rows.Count == 0) //2014.05 추가
                {
                    uniBase.UMessage.DisplayMessageBox("900014", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                bool reThrow = uniBase.UExceptionController.AutoProcessException(ex);
                if (reThrow)
                    throw;

                return false;
            }

            uniGrid1.ResetGrid();

            InitSpreadSheet();
            uniGrid1.ResetGrid();

            InitSpreadSheet();
            uniGrid1.uniGridSetDataBinding(cqtdsF2316MA1.E_F_BDGN);

            cqtdsF2316MA1.E_F_BDGN.Merge(idataset.Tables[0], false, MissingSchemaAction.Ignore);

            for (int i = 0; i < uniGrid1.Rows.Count; i++)
            {
                if (uniGrid1.Rows[i].Cells["dept_cd"].Value.ToString() == "zzzz")
                {
                    uniGrid1.Rows[i].Cells["dept_cd"].Value = "";
                }
            }
            cqtdsF2316MA1.AcceptChanges();

            return true;
        }

        #endregion

        #region ■■ 4.4.2 DBDelete(Single)

        private bool DBDelete()
        {
            return true;
        }

        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {

            return true;

        }

        #endregion

        #endregion

        #endregion

        #region ▶ 5. Event method part

        #region ■ 5.1 Single control event implementation group



        #endregion

        #region ■ 5.2 Grid   control event implementation group

        #region MultiMulti Template Event ( Relation )

        #endregion

        #region ▶ Click >>> AfterCellActivate | AfterRowActivate | AfterSelectChange


        private void uniGrid1_AfterRowActivate(object sender, EventArgs e)
        {
        }
        #endregion ▶ Click >>> AfterSelectChange

        #region ▶ DblClick >>> DoubleClickCell

        #endregion ▶ DblClick >>> DoubleClickCell

        #region ▶ MouseDown >>> MouseDown

        #endregion ▶ MouseDown >>> MouseDown

        #region ▶ ScriptLeaveCell >>> BeforeCellDeactivate

        #endregion ▶ ScriptLeaveCell >>> BeforeCellDeactivate

        #region ▶ ButtonClicked >>> ClickCellButton

        #endregion ▶ ButtonClicked >>> ClickCellButton

        #region ▶ ComboSelChange >>> CellListSelect

        #endregion ▶ ComboSelChange >>> CellListSelect

        #region ▶ Change >>> CellChange

        #endregion ▶ Change >>> CellChange


        #endregion

        #region ■ 5.3 TAB    control event implementation group
        #endregion

        #endregion

        #region ▶ 6. Popup method part

        #region ■ 6.1 Common popup implementation group


        private void popOrgId_BeforePopupOpen(object sender, Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Department Change ID Popup";
            e.PopupPassData.ConditionCaption = "Department Change ID";

            e.PopupPassData.SQLFromStatements = "horg_abs(NOLOCK)";
            e.PopupPassData.SQLWhereStatements = "";
            e.PopupPassData.SQLWhereInputCodeValue = popOrgId.CodeValue;
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = false;

            e.PopupPassData.GridCellCode = new String[3];
            e.PopupPassData.GridCellCodeAlias = new String[3];
            e.PopupPassData.GridCellCaption = new String[3];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[3];

            e.PopupPassData.GridCellCode[0] = "orgid";
            e.PopupPassData.GridCellCode[1] = "orgnm + '(' + orgdt + ')'";
            e.PopupPassData.GridCellCode[2] = "orgdt";

            e.PopupPassData.GridCellCodeAlias[0] = "orgid";
            e.PopupPassData.GridCellCodeAlias[1] = "orgnm";
            e.PopupPassData.GridCellCodeAlias[2] = "orgdt";

            e.PopupPassData.GridCellCaption[0] = "Department Change ID";
            e.PopupPassData.GridCellCaption[1] = "Department Change Name";
            e.PopupPassData.GridCellCaption[2] = "Department Change Date";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[2] = enumDef.GridCellType.Hidden;
        }
        private void popOrgId_AfterPopupClosed(object sender, Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popOrgId.CodeValue = iDataSet.Tables[0].Rows[0]["orgid"].ToString();
            popOrgId.CodeName = iDataSet.Tables[0].Rows[0]["orgnm"].ToString();
        }

        

        private void popBdgCdFr_BeforePopupOpen(object sender, Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Budget Code Popup";
            e.PopupPassData.ConditionCaption = "Budget";

            e.PopupPassData.SQLFromStatements = "F_BDG_ACCT A(NOLOCK) ";
            e.PopupPassData.SQLWhereStatements = "";
            e.PopupPassData.SQLWhereInputCodeValue = popBdgCdFr.CodeValue;
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = false;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "A.BDG_CD";
            e.PopupPassData.GridCellCode[1] = "A.GP_ACCT_NM";

            e.PopupPassData.GridCellCaption[0] = "Budget.";
            e.PopupPassData.GridCellCaption[1] = "Budget Desc.";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }
        private void popBdgCdFr_AfterPopupClosed(object sender, Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popBdgCdFr.CodeValue = iDataSet.Tables[0].Rows[0]["BDG_CD"].ToString();
            popBdgCdFr.CodeName = iDataSet.Tables[0].Rows[0]["GP_ACCT_NM"].ToString();
        }

        private void popBdgCdTo_BeforePopupOpen(object sender, Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Budget Code Popup";
            e.PopupPassData.ConditionCaption = "Budget";

            e.PopupPassData.SQLFromStatements = "F_BDG_ACCT A(NOLOCK) ";
            e.PopupPassData.SQLWhereStatements = "";
            e.PopupPassData.SQLWhereInputCodeValue = popBdgCdTo.CodeValue;
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = false;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "A.BDG_CD";
            e.PopupPassData.GridCellCode[1] = "A.GP_ACCT_NM";

            e.PopupPassData.GridCellCaption[0] = "Budget.";
            e.PopupPassData.GridCellCaption[1] = "Budget Desc.";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }
        private void popBdgCdTo_AfterPopupClosed(object sender, Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popBdgCdTo.CodeValue = iDataSet.Tables[0].Rows[0]["BDG_CD"].ToString();
            popBdgCdTo.CodeName = iDataSet.Tables[0].Rows[0]["GP_ACCT_NM"].ToString();
        }

        #endregion

        #region ■ 6.2 User-defined popup implementation group

        private void OpenNumberingType(string iWhere)
        {
            #region ▶▶▶ 10.1.2.1 Popup Constructors
            //CommonPopup cp = new CommonUtil.CommonPopup(PopupType.AutoNumbering);

            //string[] arrRet = cp.showModalDialog(InputParam1);

            #endregion

            #region ▶▶▶ 10.1.2.2 Setting Returned Data


            #endregion

        }

        #endregion

        #endregion

        #region ▶ 7. User-defined method part

        #region ■ 7.1 User-defined function group

        #endregion

        #endregion

        private void popORG_CD_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "예산부서그룹";
            e.PopupPassData.ConditionCaption = "예산부서그룹";

            e.PopupPassData.SQLFromStatements = "f_bdg_org A(NOLOCK) ";
            e.PopupPassData.SQLWhereStatements = "org_change_id ="+uniBase.UCommon.FilterVariable(popOrgId.CodeValue,"''",enumDef.FilterVarType.BraceWithSingleQuotation,true);
            e.PopupPassData.SQLWhereInputCodeValue = popORG_CD.CodeValue;
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = false;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "A.org_cd";
            e.PopupPassData.GridCellCode[1] = "A.org_nm";

            e.PopupPassData.GridCellCaption[0] = "예산부서그룹";
            e.PopupPassData.GridCellCaption[1] = "예산부서그룹(명)";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }

        private void popORG_CD_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popORG_CD.CodeValue = iDataSet.Tables[0].Rows[0]["org_cd"].ToString();
            popORG_CD.CodeName = iDataSet.Tables[0].Rows[0]["org_nm"].ToString();
        }
    }
}
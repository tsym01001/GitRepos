/***************************************************************************
*                Producted by Toshiya Yamanaka 2016
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HOSYU
{
    using System.IO;
    using System.Xml.Serialization;
    using StringList = List<string>;
    using StringDic = Dictionary<string, string>;
    using System.Drawing;
    using System.Collections;
    using System.Diagnostics;
    using System.Data;
    using System.Data.OleDb;
    using System.Configuration;
    using System.Runtime.Serialization;

    public partial class MainForm : Form
    {

        private StringList sList = new StringList();

        private int prevTabIndex;
        private DateTime modAcceptDateTime = new DateTime();
        private DateTime modProcDateTime = new DateTime();
        private DateTime modContinuationDateTime = new DateTime();
        private DateTime modCompleteDateTime = new DateTime();
        private ComboBox cbCaller = null;
        private int cbSelectedIndex = -1;
        private TemplateText objTmp = null;
        private LabelTextControl[] lblTxtCtrls = null;
        private string[] lstLblKeys;
        private string[] lstDomIDs;
        private int[] DataRef = new int[] { 0, 3, 6, 9 };
        private string PdfFile;
        private StringList dbFields = new StringList();
        private AccessDB accDB= null;
        private tabUI[] dbtabs;
        private string txtOutDataUndoBuffer=string.Empty;

        /******************************************************
        *   受付番号、所轄、部署の情報表示。---------読み込み専用
        *******************************************************/
        public string strAcceptInfoData
        {
            get
            {
                string sARea = (txtArea.Text == string.Empty) ? "(所轄：未記入)" : string.Format("(所轄：{0})",txtArea.Text);
                string sPost = (txtPost.Text == string.Empty) ? "(部署：未記入)" : string.Format("(部署：{0})",txtPost.Text);
                return  string.Format("-----[受付番号: {0}-{1} {2} {3} ]-----",txtReceptNum1.Text,txtReceptNum2.Text,sARea,sPost);
            }
        }

        
        /******************************************************
        *   初期化処理2
        *******************************************************/
        private void InitForm1Data()
        {
            //　Accessをリソースとして取り込んでおき、デフォルトでは最初にこのデータベースを
            //　実行ファイルディレクトリ配下に取り出し読み込む。
            if (File.Exists(Properties.Resources.Defaultdb) == false)
            {
                using (FileStream fs = new FileStream(Properties.Resources.Defaultdb, FileMode.Create))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        fs.Write(Properties.Resources.KenkeiHosyu, 0, Properties.Resources.KenkeiHosyu.Length);
                    }
                }
            }
            this.Icon = Properties.Resources.hosyu;
            objTmp = new TemplateText();
            lstLblKeys = Properties.Resources.LblKeys.Split('|');
            lstDomIDs = Properties.Resources.resDomID.Split('|');

            txtReceptNum2.Items.AddRange(lstDomIDs);
            txtReceptNum2.Items.Reverse();
            domainQryID.Items.AddRange(lstDomIDs);
            domainQryID.Items.Reverse();

            lblTxtCtrls = new LabelTextControl[] {labelTextControl1,labelTextControl2,labelTextControl3,labelTextControl4,
                labelTextControl5,labelTextControl6,labelTextControl7,labelTextControl8,
                labelTextControl9,labelTextControl10,labelTextControl11,labelTextControl12,
                labelTextControl13,labelTextControl14 };

            for (int i = 0; i < lblTxtCtrls.Length; i++)
            {
                lblTxtCtrls[i].LabelControl.Text = lstLblKeys[i];
            }

            foreach (int iref in DataRef)
            {
                lblTxtCtrls[iref].TextControl.BackColor = Color.LemonChiffon;
                lblTxtCtrls[iref].TextControl.MaxLength = 12;
                lblTxtCtrls[iref].TextControl.KeyPress += OnKeyPress;
            }

            Size tabsize = new Size(0,588);
            foreach(TabPage pg in tabControl1.TabPages)
            {
                pg.AutoScroll = true;
                pg.AutoScrollMinSize = tabsize;
            }
            prevTabIndex = -1;

            dbtabs = new tabUI[] {new tabUI(chkTab0_0,txt0_0,0,false),new tabUI(chkTab0_1,txt0_1,0,false),new tabUI(chkTab0_2,txt0_2,0,false),
                    new tabUI(chkTab0_3,txt0_3,0,false),new tabUI(chkTab0_4,txt0_4,0,true),new tabUI(chkTab1_0,txt1_0,1,false),
                    new tabUI(chkTab1_1,txt1_1,1,true),new tabUI(chkTab1_2,txt1_2,1,false),new tabUI(chkTab2_0,txt2_0,2,false),
                    new tabUI(chkTab2_1,null,2,false),new tabUI(chkTab2_2,txt2_2,2,false),new tabUI(chkTab2_3,txt2_3,2,true),
                    new tabUI(chkTab2_4,txt2_4,2,true),new tabUI(chkTab2_5,txt2_5,2,false) };
        }


        /******************************************************
        *   コンストラクタ
        *******************************************************/
        public MainForm()
        {
            InitializeComponent();
            InitForm1Data();
        }


        /******************************************************
        *   データベース再接続
        *******************************************************/
        public void AccDBReConnect()
        {
            try {
                objTmp.DatabaseInfo.DataSourceString = txtAccessDbf.Text;
                if (accDB == null)
                {
                    accDB = new AccessDB(objTmp.DatabaseInfo.DBConnectionString);
                }
                else {
                    accDB.ConnetctionString = objTmp.DatabaseInfo.DBConnectionString;
                    accDB.DbOpen();
                }
            }
            catch(DBIOException)
            {
                throw;
            }
        }



        /******************************************************
        *   フォームロードイベント 
        *******************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

            objTmp.ConfigPath = Application.ExecutablePath;

            LoadTemplate();

            try {
                accDB = new AccessDB(objTmp.DatabaseInfo.DBConnectionString);
            }catch(DBIOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.acceptTblTableAdapter.Fill(this.kenkeiHosyuDataSet.AcceptTbl);
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    (c as Label).TabIndex = -1;
                }
            }
            modAcceptDateTime = dateTimePicker1.Value;
            modProcDateTime = modAcceptDateTime;
            modContinuationDateTime = modAcceptDateTime;
            modCompleteDateTime = modAcceptDateTime;
            tabControl1.SelectedIndex = 0;
            tabControl1_SelectedIndexChanged(null, null);
            txtReceptNum2.SelectedIndex = txtReceptNum2.Items.Count-1;
            domainQryID.SelectedIndex = domainQryID.Items.Count - 1;

            

        }


        /******************************************************
        *   経過入力(担当者からの連絡)
        *******************************************************/
        private void btnCopy1_Click(object sender, EventArgs e)
        {
            txtOutData.AppendText(string.Format("報告：■{0}　{1}:{2}　{3}（{4}）\r\n",
            txtDayProc.Text,
            txtTimeProc.Text,
            txtMinuteProc.Text,
            txtReport.Text,
            txtInputsProc.Text));
            tabControl1.SelectedIndex = 2;
        }


        /******************************************************
        *   完了報告入力(PDF)
        *******************************************************/
        private void btnCopy2_Click(object sender, EventArgs e)
        {
            string strToken = "";
            if (chkComplete.Checked)
                strToken = " 完了";
            else
                strToken = " 継続";

            sList.Clear();
            sList.AddRange(txtOutData.Lines);
            sList.Add(strAcceptInfoData);
            sList.Add("《保守サービス報告書》");

            if (chkComplete.Checked)
                sList.Add(string.Format("完了日時：{0} {1}:{2}{3}", modCompleteDateTime.ToString("yyyy/MM/dd"), txtTime.Text, txtMinute.Text, strToken));
            else
                sList.Add(string.Format("完了日時：{0} {1}:{2}{3}", modContinuationDateTime.ToString("yyyy/MM/dd"), txtTime.Text, txtMinute.Text, strToken));

            sList.Add(string.Format("担当：{0}様", txtCharger.Text));
            string line = "原因：";
            foreach (string s in txtCause.Lines)
            {
                sList.Add(line + s);
                if (line == "原因：")
                {
                    line = "　　　";
                }
            }
            line = "処置：";
            foreach (string s in txtProc.Lines)
            {
                sList.Add(line + s);
                if (line == "処置：")
                {
                    line = "　　　";
                }
            }
            sList.Add("入力担当：" + txtInputsPdf.Text);
            sList.Add("--------------------------------------------------------\n");
            txtOutData.Lines = sList.ToArray();
            tabControl1.SelectedIndex = 2;
        }

        /******************************************************
        *   TabControl1 選択変更
        *******************************************************/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prevTabIndex != tabControl1.SelectedIndex)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0://受付入力---初期対応
                    case 1://報告書入力 ---1　経過報告　2 PDF完了入力
                        ModTextValueChangeTab1();
                        toolStripStatusLabel1.Text = string.Empty;
                        break;
                    case 2://設定データ(クリップボード)
                        txtOutData.Focus();
                        txtOutData.Select(0, 0);
                        break;
                    case 3://テンプレート設定
                        lblTxtCtrls[0].TextControl.Focus();
                        if (lblTxtCtrls[0].TextControl.Enabled)
                            lblTxtCtrls[0].TextControl.Select(0, 0);
                        toolStripStatusLabel1.Text = string.Empty;
                        break;
                    case 4://データベースメンテナンス
                        ModTextValueChangeTab1();
                        toolStripStatusLabel1.Text = string.Empty;
                        break;
                    default:
                        break;
                }
                prevTabIndex = tabControl1.SelectedIndex;
            }
        }

        /******************************************************
        *   選択タブ(tabControll2)のインデックス値によって
        *   それぞれ設定するテキストを変更
        *******************************************************/
        private void ModTextValueChangeTab2()
        {
            if (tabControl2.SelectedIndex == 0) // 経過入力
            {
                lblProcInfo.Text = strAcceptInfoData;
                modProcDateTime = dateTimePicker1.Value;
                if (modProcDateTime < modAcceptDateTime)
                {
                    modProcDateTime = modAcceptDateTime;
                }
                txtDayProc.Clear();
                txtDayProc.Text = modProcDateTime.ToString("yyyyMMdd");
                txtTimeProc.Focus();
                txtTimeProc.Select(0, 0);
            }
            else
            {
                lblPdfInfo.Text = strAcceptInfoData;
                if (chkComplete.Checked)
                {
                    modCompleteDateTime = dateTimePicker1.Value;
                    if (modContinuationDateTime < modAcceptDateTime)
                    {
                        modContinuationDateTime = modAcceptDateTime;
                    }
                    if (modCompleteDateTime < modContinuationDateTime)
                    {
                        modCompleteDateTime = modContinuationDateTime;
                    }
                    txtDay.Clear();
                    txtDay.Text = modCompleteDateTime.ToString("yyyyMMdd");
                }
                else {
                    modContinuationDateTime = dateTimePicker1.Value;
                    if (modContinuationDateTime < modAcceptDateTime)
                    {
                        modContinuationDateTime = modAcceptDateTime;
                    }
                    txtDay.Clear();
                    txtDay.Text = modContinuationDateTime.ToString("yyyyMMdd");
                }
                txtTime.Focus();
                txtTime.Select(0, 0);
            }

        }


        /******************************************************
        *   TabControl2 選択変更
        *******************************************************/
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModTextValueChangeTab2();
        }


        /******************************************************
        *   選択タブ(tabControll1)のインデックス値によって
        *   それぞれ設定するテキストを変更
        *******************************************************/
        private void ModTextValueChangeTab1()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0://受付入力---初期対応
                    modCompleteDateTime = modContinuationDateTime = modProcDateTime = modAcceptDateTime = dateTimePicker1.Value;
                    txtRecvDay.Clear();
                    txtRecvDay.Text = modAcceptDateTime.ToString("yyyyMMdd");
                    txtReceptNum1.Clear();
                    txtReceptNum1.Text = modAcceptDateTime.ToString("yyyyMMdd");
                    txtReceptNum2.Focus();
                    break;
                case 1://報告書入力
                    if (tabControl2.SelectedIndex == 0)
                    {
                        modProcDateTime = dateTimePicker1.Value;
                        ModTextValueChangeTab2();
                    }
                    else {
                        if (chkComplete.Checked)
                        {
                            modCompleteDateTime = dateTimePicker1.Value;
                            ModTextValueChangeTab2();
                        }
                        else
                        {
                            modContinuationDateTime = dateTimePicker1.Value;
                            ModTextValueChangeTab2();
                        }
                    }
                    break;
                case 4://Databaseメンテナンス
                    modAcceptDateTime = dateTimePicker1.Value;
                    if (txtQryAcceptID.Enabled)
                    {
                        txtQryAcceptID.Text = modAcceptDateTime.ToString("yyyyMMdd");
                    }
                    btnQuery.Focus();
                    break;
                default:
                    break;
            }
        }



        /******************************************************
        *   カレンダーの設定値が変更された時
        *******************************************************/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ModTextValueChangeTab1();
        }


        /******************************************************
        *   入力監査 ----- メッセージ表示処理
        *******************************************************/
        private void RequireMessage(string s)
        {
            string msg = string.Format("{0}は必須入力項目です", s);
            MessageBox.Show(msg);
        }

        private void CheckBehavior(CheckBox cb)
        {
            if (cb == null) return;
            switch (cb.Name)
            {
                case "chkAccept":
                    if (cb.Checked)
                    {
                        txtQryAcceptID.Enabled = true;
                        domainQryID.Enabled = true;
                    }
                    else
                    {
                        txtQryAcceptID.Enabled = false;
                        domainQryID.Enabled = false;
                    }
                    break;
                case "chkTab0_0":
                    if (cb.Checked)
                    {
                        txt0_0.Enabled = true;
                    }
                    else
                    {
                        txt0_0.Enabled = false;
                    }
                    break;
                case "chkTab0_1":
                    if (cb.Checked)
                    {
                        txt0_1.Enabled = true;
                    }
                    else
                    {
                        txt0_1.Enabled = false;
                    }
                    break;
                case "chkTab0_2":
                    if (cb.Checked)
                    {
                        txt0_2.Enabled = true;
                    }
                    else
                    {
                        txt0_2.Enabled = false;
                    }
                    break;
                case "chkTab0_3":
                    if (cb.Checked)
                    {
                        txt0_3.Enabled = true;
                    }
                    else
                    {
                        txt0_3.Enabled = false;
                    }
                    break;
                case "chkTab0_4":
                    if (cb.Checked)
                    {
                        txt0_4.Enabled = true;
                    }
                    else
                    {
                        txt0_4.Enabled = false;
                    }
                    break;
                case "chkTab1_0":
                    if (cb.Checked)
                    {
                        txt1_0.Enabled = true;
                    }
                    else
                    {
                        txt1_0.Enabled = false;
                    }
                    break;
                case "chkTab1_1":
                    if (cb.Checked)
                    {
                        txt1_1.Enabled = true;
                    }
                    else
                    {
                        txt1_1.Enabled = false;
                    }
                    break;
                case "chkTab1_2":
                    if (cb.Checked)
                    {
                        txt1_2.Enabled = true;
                    }
                    else
                    {
                        txt1_2.Enabled = false;
                    }
                    break;
                case "chkTab2_0":
                    if (cb.Checked)
                    {
                        txt2_0.Enabled = true;
                    }
                    else
                    {
                        txt2_0.Enabled = false;
                    }
                    break;
                case "chkTab2_1":
                    if (cb.Checked)
                    {
                        cb.Text = "継続/完了 :[完了]";
                    }
                    else
                    {
                        cb.Text = "継続/完了 :[継続]";
                    }
                    break;
                case "chkTab2_2":
                    if (cb.Checked)
                    {
                        txt2_2.Enabled = true;
                    }
                    else
                    {
                        txt2_2.Enabled = false;
                    }
                    break;
                case "chkTab2_3":
                    if (cb.Checked)
                    {
                        txt2_3.Enabled = true;
                    }
                    else
                    {
                        txt2_3.Enabled = false;
                    }
                    break;
                case "chkTab2_4":
                    if (cb.Checked)
                    {
                        txt2_4.Enabled = true;
                    }
                    else
                    {
                        txt2_4.Enabled = false;
                    }
                    break;
                case "chkTab2_5":
                    if (cb.Checked)
                    {
                        txt2_5.Enabled = true;
                    }
                    else
                    {
                        txt2_5.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        /******************************************************
        *   データベース検索 -----　チェック項目変更時イベント
        *******************************************************/
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBehavior(sender as CheckBox);
        }   


        /******************************************************
        *   テキストキー入力チェック ----- 数値のみ許可の項目
        *******************************************************/
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            char[] kdata = {'0','1','2','3','4','5','6','7','8','9',
                (char)Keys.Enter,(char)Keys.Delete,(char)Keys.Back,(char)Keys.Left,
                (char)Keys.Right,(char)Keys.Tab,(char)Keys.Home,(char)Keys.End };

            if (sender is TextBox)
            {

                if (kdata.Contains(e.KeyChar) == false)
                {
                    e.Handled = true;
                }

            }
        }


 


        /******************************************************
        *   
        *   日付を入力した文字からDateTimeに変換
        *******************************************************/
        private void txtReceptNum1_Validated(object sender, EventArgs e)
        {
            modAcceptDateTime = DateTime.ParseExact(txtReceptNum1.Text, "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }



        /******************************************************
        *   コンボボックス上でポップアップメニュー ----- 追加
        *******************************************************/
        private void AddCmbItem()
        {
            if (cbCaller == null)
                return;
            string s = cbCaller.Text.Trim();
            if (s != string.Empty)
            {
                if (cbCaller.Items.Contains(s) == false)
                {
                    cbCaller.Items.Add(s);
                }
            }
            cbSelectedIndex = -1;
            cbCaller = null;
        }

        /******************************************************
        *   コンボボックス上でポップアップメニュー ----- 削除
        *******************************************************/
        private void DeleteCmbItem()
        {
            if (cbCaller == null)
                return;
            string s = cbCaller.Text.Trim();
            if (s != string.Empty)
            {
                if (cbCaller.Items.Contains(s))
                {
                    cbCaller.Items.Remove(s);
                }
            }
            cbSelectedIndex = -1;
            cbCaller = null;
        }

        /******************************************************
        *   コンボボックス上でポップアップメニュー ----- 変更
        *******************************************************/
        private void ModifyCmbItem()
        {
            if (cbCaller == null)
                return;
            string strMod = cbCaller.Text.Trim();
            if (strMod != string.Empty)
            {
                if ((cbSelectedIndex >= 0) && (cbSelectedIndex < cbCaller.Items.Count))
                {
                    cbCaller.Items[cbSelectedIndex] = strMod;
                }
            }
            cbSelectedIndex = -1;
            cbCaller = null;
        }


        /******************************************************
        *   コンボボックスのテキスト上でSHFT+ENTER時処理
        *******************************************************/
        private void OnCmbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox cb = (sender as ComboBox);
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        cbCaller = (sender as ComboBox);
                        AddCmbItem();
                    }
                }
            }
        }


        /******************************************************
        *   コンテキスト --- 追加
        *******************************************************/
        private void OnContextAdd(object sender, EventArgs e)
        {
            AddCmbItem();
        }

        /******************************************************
        *   コンテキスト --- 削除
        *******************************************************/
        private void OnContextDelete(object sender, EventArgs e)
        {
            DeleteCmbItem();
        }

        /******************************************************
        *   コンテキスト --- 変更
        *******************************************************/
        private void OnContextModify(object sender, EventArgs e)
        {
            ModifyCmbItem();
        }


        /******************************************************
        *   ポップアップを開こうとした時のイベント
        *******************************************************/
        private void CmbMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)sender;
            Control source = menu.SourceControl;
            if (source != null)
            {
                if (source is ComboBox)
                {
                    cbCaller = (source as ComboBox);
                }
            }
        }


        /******************************************************
        *   コンボボックス選択変更時イベント
        *******************************************************/
        private void OnnSelIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            if (cb != null)
            {
                cbSelectedIndex = cb.SelectedIndex;
            }
        }

        /******************************************************
        *   受付　DBレコード追加
        *******************************************************/
        private void btnAccept_Click(object sender, EventArgs e)
        {

        }


        /******************************************************
        *   経過報告　DBレコード追加
        *******************************************************/
        private void btnAddProc_Click(object sender, EventArgs e)
        {

        }



        /******************************************************
        *   PDF報告　DBレコード追加
        *******************************************************/
        private void btnAddPdf_Click(object sender, EventArgs e)
        {

        }



        /******************************************************
        *   特定のラベルをダブルクリックした時に関連付けたテキストに
        *   入力される定型の文字列処理
        *******************************************************/
        private void OnLblDoubleclickMethod(object sender, EventArgs e)
        {
            string strTmp;
            if (sender is Label) {
                string slabel = ((Label)sender).Text;
                switch (slabel)
                {
                    case "受付番号：":
                        strTmp=objTmp.Pairs.values[0];
                        txtReceptNum1.Text = strTmp.Substring(0, 8);
                        txtReceptNum2.Text = strTmp.Substring(8, 2);
                        break;
                    case "管轄：":
                        txtArea.Text = objTmp.Pairs.values[1];
                        break;
                    case "部署：":
                        txtPost.Text = objTmp.Pairs.values[2];
                        break;
                    case "受付日時：":
                        txtRecvDay.Text = objTmp.Pairs.values[3];
                        break;
                    case "システム名：":
                        txtSystName.Text = objTmp.Pairs.values[4];
                        break;
                    case "症状：":
                        txtSymptom.Text = objTmp.Pairs.values[5];
                        break;
                    case "連絡日時：":
                        strTmp = objTmp.Pairs.values[6];
                        txtDay.Text = strTmp.Substring(0, 8);
                        txtTime.Text = strTmp.Substring(8, 2);
                        txtMinute.Text = strTmp.Substring(10, 2);
                        break;
                    case "報告：":
                        txtReport.Text = objTmp.Pairs.values[7];
                        break;
                    case "入力担当：":
                        txtInputsPdf.Text = objTmp.Pairs.values[8];
                        txtInputsProc.Text = objTmp.Pairs.values[8];
                        break;
                    case "完了日時：":
                        strTmp = objTmp.Pairs.values[9];
                        txtDay.Text = strTmp.Substring(0, 8);
                        txtTime.Text = strTmp.Substring(8, 2);
                        txtMinute.Text = strTmp.Substring(10, 2);
                        break;
                    case "担当：":
                        txtCharger.Text = objTmp.Pairs.values[10];
                        break;
                    case "原因：":
                        txtCause.Text = objTmp.Pairs.values[11];
                        break;
                    case "処置：":
                        txtProc.Text = objTmp.Pairs.values[12];
                        break;
                    case "出力データ：":
                        txtOutData.Text = objTmp.Pairs.values[13];
                        break;
                }
            }
        }

        /******************************************************
        *   フォームクローズ時イベント
        *******************************************************/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("終了しますか(Yes/No)", "県警保守", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;    
            }
            SaveTemplate();
        }

        /******************************************************
        *   テンプレートの設定
        *   (ラベルダブルクリック時入力補助機能) ---- 保存
        *******************************************************/
        private void SaveTemplate()
        {
            try {
                //Config1
                for (int i = 0; i < lblTxtCtrls.Length; i++)
                {
                    objTmp.Pairs.lbls[i] = lstLblKeys[i];
                    objTmp.Pairs.values[i] = lblTxtCtrls[i].TextControl.Text;
                }
                //Config2
                objTmp.ComboItems.itemsArea.Clear();
                objTmp.ComboItems.itemsPost.Clear();
                objTmp.ComboItems.itemsCharger.Clear();
                objTmp.ComboItems.itemsInputs.Clear();

                objTmp.ComboItems.itemsArea.AddRange(txtArea.Items);
                objTmp.ComboItems.itemsPost.AddRange(txtPost.Items);
                objTmp.ComboItems.itemsCharger.AddRange(txtCharger.Items);
                if (txtInputsProc.Items.Count > 0)
                    objTmp.ComboItems.itemsInputs.AddRange(txtInputsProc.Items);
                else if (txtInputsPdf.Items.Count > 0)
                    objTmp.ComboItems.itemsInputs.AddRange(txtInputsPdf.Items);
                //Config3

                objTmp.DatabaseInfo.DataSourceString = txtAccessDbf.Text;
                objTmp.DatabaseInfo.ProviderString = string.Empty;
                objTmp.Serialize();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /******************************************************
        *   テンプレートの設定
        *   (ラベルダブルクリック時入力補助機能) ---- 読み込み
        *******************************************************/
        private void LoadTemplate()
        {
            if (File.Exists(objTmp.ConfigPath1) && File.Exists(objTmp.ConfigPath2))
            {
                try {
                    objTmp.Deserialize();

                    //Config1
                    objTmp.Pairs.lbls = lstLblKeys;
                    for (int i = 0; i < lstLblKeys.Length; i++)
                    {
                        lblTxtCtrls[i].TextControl.Text = objTmp.Pairs.values[i];
                    }

                    //Config2
                    txtArea.Items.Clear();
                    txtPost.Items.Clear();
                    txtCharger.Items.Clear();
                    txtInputsProc.Items.Clear();
                    txtInputsPdf.Items.Clear();
                    txtArea.Items.AddRange(objTmp.ComboItems.itemsArea.ToArray());
                    txtPost.Items.AddRange(objTmp.ComboItems.itemsPost.ToArray());
                    txtCharger.Items.AddRange(objTmp.ComboItems.itemsCharger.ToArray());
                    txtInputsProc.Items.AddRange(objTmp.ComboItems.itemsInputs.ToArray());
                    txtInputsPdf.Items.AddRange(objTmp.ComboItems.itemsInputs.ToArray());

                    //Config3
                    txtAccessDbf.Text = objTmp.DatabaseInfo.DataSourceString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /******************************************************
        *   テンプレートの設定
        *   保存ボタン押下イベント
        *******************************************************/
        private void btnSaveTmp_Click(object sender, EventArgs e)
        {
            SaveTemplate();
            toolTip.SetToolTip(btnSaveTmp, "設定を保存しました");
        }

        /******************************************************
        *   テンプレートの設定
        *   読み込みボタン押下イベント
        *******************************************************/
        private void btnLoadTmp_Click(object sender, EventArgs e)
        {
            LoadTemplate();
            toolTip.SetToolTip(btnLoadTmp, "設定を読み込みました");
        }

        /******************************************************
        *   設定ファイル
        *   クリップボードにコピー押下イベント
        *******************************************************/
        private void btnToClipboard_Click(object sender, EventArgs e)
        {
            if (txtOutData.Text == string.Empty) return;
            toolStripStatusLabel1.Text = string.Empty;
            Clipboard.SetText(txtOutData.Text, TextDataFormat.Text);
            toolStripStatusLabel1.Text = ("設定をクリップボードにコピーしました");
        }


        /******************************************************
        *   PDFドキュメントを開く、(関連付けされていないとエラーメッセージ表示)
        *******************************************************/
        private void btnRunAcrobat_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdlg = new OpenFileDialog();
            opdlg.DefaultExt = "pdf";
            opdlg.FileName = "*.pdf";
            opdlg.Filter = "PDFファイル(*.pdf)|*.pdf|全てのファイル(*.*)|*.*";
            opdlg.FilterIndex = 1;
            if (opdlg.ShowDialog() == DialogResult.OK)
            {
                PdfFile = opdlg.FileName;
                try {
                    Process.Start(PdfFile);
                }
                catch(Win32Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }




        /******************************************************
        *   データベース -----　チェック項目のチェック項目
        *******************************************************/
        private bool DbCheckBoxCheck(int index)
        {
            bool resultValue = false;

            if (chkAccept.Checked)
            {
                resultValue = true;
            }
            else {
                foreach (tabUI ui in dbtabs)
                {
                    if (ui.Index == index)
                    {
                        if (ui.ChkSwitch.Checked)
                        {
                            resultValue = true;
                            break;
                        }
                    }
                }
            }
            return resultValue;

        }


        /******************************************************
        *   データベース -----　入力項目をチェックしリストへ追加
        *******************************************************/
        private void DbItemCheckAndListBuffer()
        {
            string strParamData = string.Empty;
            dbFields.Clear();
            if (chkAccept.Checked)
            {
                strParamData = string.Format("{0}{1}",txtQryAcceptID.Text, domainQryID.Text);
                if (strParamData != string.Empty)
                {
                    dbFields.Add(strParamData);
                }
            }
            foreach (tabUI ui in dbtabs)
            {
                if (ui.ChkSwitch.Checked)
                {
                    if (ui.TxtFilter == null)//完了
                    {
                        strParamData = "TRUE";
                    }
                    else
                    {
                        strParamData = ui.TxtFilter.Text.Trim();
                    }
                }
                else
                {
                    if (ui.TxtFilter == null)//継続
                    {
                        strParamData = "FALSE";
                    }
                }
                if (strParamData != string.Empty)
                {
                    dbFields.Add(strParamData);
                }
            }
        }


        /******************************************************
        *   データベース検索 -----　検索ボタン押下イベント
        *******************************************************/
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if ( DbCheckBoxCheck(tabCtrlDBQuery.SelectedIndex) )
            {
                DbItemCheckAndListBuffer();
                if (dbFields.Count == 0)
                {
                    SelectNoFilter();
                }
                else {
                    SelectByFilter();
                }
            }
            else
            {
                SelectNoFilter();
            }
        }

        /******************************************************
        *   データベース検索 -----　リストにある項目で絞り込み検索
        *******************************************************/
        private void SelectByFilter()
        {
            DataTable refTeble;
            string sqlparams = string.Join(",", dbFields.ToArray());
//            string strSql = string.Format("select {0} from ")

            
            tabControl1.TabPages.Add("[ 検索結果 ]");

        }


        /******************************************************
        *   データベース検索 -----　無条件検索
        *******************************************************/
        private void SelectNoFilter()
        {
            /*
            */

        }

        /******************************************************
        *   データベース(Access)ファイルの設定
        *******************************************************/
        private void btnBrowseAccess_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.CheckPathExists = true;
                dlg.CheckFileExists = true;
                dlg.DefaultExt = "accdb";
                dlg.FileName = "*.accdb";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    txtAccessDbf.Text = dlg.FileName;
                }
            }
            
        }

        private void lblAccLocation_DoubleClick(object sender, EventArgs e)
        {
            using (ConInfoForm cif = new ConInfoForm())
            {
                objTmp.DatabaseInfo.DataSourceString = txtAccessDbf.Text;
                cif.Icon = Properties.Resources.hosyu;
                cif.Caller = this;
                cif.InfoMessage = objTmp.DatabaseInfo.DBConnectionString;
                cif.ShowDialog();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnTxtClear_Click(object sender, EventArgs e)
        {
            if (txtOutDataUndoBuffer == string.Empty)
            {
                if (txtOutData.Text != string.Empty)
                {
                    txtOutDataUndoBuffer = txtOutData.Text;
                    txtOutData.Clear();
                    btnUndo.Enabled = true;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(txtOutDataUndoBuffer != string.Empty)
            {
                txtOutData.Text = txtOutDataUndoBuffer;
                txtOutDataUndoBuffer = string.Empty;
                btnUndo.Enabled = false;
            }
        }
    }



    /******************************************************
    *   データベース(Access) クラス
    *******************************************************/
    public partial class AccessDB
    {
        private string propProvider;
        private string propDateDource;
        private string propConnString;
        private DataTable dttbl = new DataTable();
        private DataSet dtset = new DataSet();
        private OleDbConnection conn = null;

        public string ConnetctionString
        {
            get { return propConnString; }
            set { propConnString = value; }
        }

        public string Provider
        {
            set { propProvider = value; }
        }

        public string DateDource
        {
            set { propDateDource = value; }
        }

        public ConnectionState State { get { return (conn != null) ? conn.State : ConnectionState.Closed; } }

        public AccessDB()
        {
            propProvider = "Microsoft.ACE.OLEDB.12.0";
            propDateDource = Properties.Resources.Defaultdb;
            propConnString = string.Format("Provider = {0};Data Source = {1}", propProvider, propDateDource);
            DbOpen();
        }

        public AccessDB(string strConnection= @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = .\default.accdb")
        {
            propConnString = strConnection;
            DbOpen();
        }

        public AccessDB(string strProvider,string strDataSource)
        {
            propProvider = strProvider;
            propDateDource = strDataSource;
            propConnString = string.Format("Provider = {0};Data Source = {1}", propProvider, propDateDource);
            DbOpen();
        }


        public void DbOpen()
        {
            try {
                if (conn == null)
                {
                    conn = new OleDbConnection();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.ConnectionString = propConnString;
                        conn.Open();
                    }
                }
            }catch(Exception ex)
            {
                throw new DBIOException(string.Format("AccessDB::Open 内で右記エラ発生→{0}",ex.Message));
            }
        }

        public void SelectCmd(string strSQL,ref DataSet resultValue)
        {

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQL;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            try
            {
                if(dtset != null)
                {
                    dtset.Clear();
                }
                else
                {
                    dtset = new DataSet();
                }
                da.Fill(dtset);
                resultValue = dtset;
            }catch(Exception ex)
            {
                throw new DBIOException(string.Format("AccessDB::SelectCmd 内で右記エラ発生→{0}", ex.Message));
            }
        }

        public void SelectCmd(string strSQL, ref DataTable resultValue)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQL;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            try
            {
                if(dttbl != null)
                {
                    dttbl.Clear(); 
                }
                else
                {
                    dttbl = new DataTable();
                }
                da.Fill(dttbl);
                resultValue = dttbl;
            }
            catch (Exception ex)
            {
                throw new DBIOException(string.Format("AccessDB::SelectCmd 内で右記エラ発生→{0}", ex.Message));
            }
        }

        public void InsertCmd(string strSQLInsert)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQLInsert;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.InsertCommand = cmd;
            OleDbTransaction trnsac=conn.BeginTransaction();
            try
            {
                trnsac.Begin();
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                trnsac.Rollback();
                throw new DBIOException(string.Format("AccessDB::strSQLInsert 内で右記エラ発生→{0}", ex.Message));
            }
            finally
            {
                trnsac.Commit();
            }
        }

        public void UpdateCmd(string strSQLUpdate)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = strSQLUpdate;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.UpdateCommand = cmd;
            OleDbTransaction trnsac = conn.BeginTransaction();
            try
            {
                trnsac.Begin();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                trnsac.Rollback();
                throw new DBIOException(string.Format("AccessDB::UpdateCmd 内で右記エラ発生→{0}", ex.Message));
            }
            finally
            {
                trnsac.Commit();
            }
        }

    }


    [Serializable]
    internal class DBIOException : Exception
    {
        public DBIOException()
        {
        }

        public DBIOException(string message) : base(message)
        {
        }

        public DBIOException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DBIOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    /******************************************************
    *   入力判定エラー例外クラス
    *******************************************************/
    internal class ValidateException : Exception
    {
        public ValidateException() { }
        public ValidateException(string message) : base(message) { }
        public ValidateException(string message, Exception inner) : base(message) { }
    }

    /******************************************************
    *   ラベルに関連付けられたテンプレートのリストのクラス。
    *   MapとかHash等ではなく単純に配列数を同じにした。
    *******************************************************/
        public partial class MapPair
    {
        public string[] lbls= { "","","","","","","","","","","","","","" };
        public string[] values = { "","","","","","","","","","","","","","" };
    }

    /******************************************************
    *   フォームのUI上にあるコンボボックスの履歴
    *   を保存するクラス
    *******************************************************/
    public partial class ListComboItems
    {
        public ArrayList itemsArea = new ArrayList();
        public ArrayList itemsPost = new ArrayList();
        public ArrayList itemsCharger = new ArrayList();
        public ArrayList itemsInputs = new ArrayList();
    }


    public partial class DBInfo
    {
        private string propProviderString = "Microsoft.ACE.OLEDB.12.0";
        private string propDataSourceString = string.Empty;

        /******************************************************
        *   プロバイダ文字列　取得(※ 現在 Office 2010 固定)
        *******************************************************/
        public string ProviderString
        {
            get
            {
                if (propProviderString == string.Empty)
                {
                    propProviderString = "Microsoft.ACE.OLEDB.12.0";
                }
                return propProviderString;
            }
            set
            {
                propProviderString = value;
            }
        }

        /******************************************************
        *   データソース　設定・取得(Access)           
        *******************************************************/
        public string DataSourceString
        {
            get { return propDataSourceString; }
            set
            {
                propDataSourceString = value;
                propDataSourceString = propDataSourceString.Trim();
                if (propDataSourceString == string.Empty)
                {
                    propDataSourceString = Properties.Resources.Defaultdb;
                }
            }
        }

        /******************************************************
        *   データベース接続文字列の取得            
        *******************************************************/
        public string DBConnectionString
        {
            get
            {
                return string.Format("Provider={0};Data Source={1}",propProviderString, propDataSourceString);
            }
        }

    }

    public partial class tabUI  
    {
        private int propIndex;
        private bool propIsPartial;
        private CheckBox propChkSwitch;
        private TextBox propTxtFilter;

        public int Index
        {
            get{return this.propIndex;}
            set{ this.propIndex = value; }
        }

        public bool IsPartial
        {
            get { return this.propIsPartial; }
            set { this.propIsPartial = value; }
        }

        public CheckBox ChkSwitch
        {
            get { return this.propChkSwitch; }
            set { this.propChkSwitch=value; }
        }

        public TextBox TxtFilter
        {
            get { return this.propTxtFilter; }
            set { this.propTxtFilter=value; }
        }

        public tabUI(CheckBox chkValue,TextBox txtValue,int tabIndex=0,bool partialserch=false)
        {
            this.propChkSwitch = chkValue;
            this.propTxtFilter = txtValue;
            this.propIndex = tabIndex;
            this.propIsPartial = partialserch;
        }
    }


    /******************************************************
    *   テンプレート-リストクラスの保存、読み込みを行うクラス
    *   xmlフォーマット
    *******************************************************/
    public partial class TemplateText
    {
        private MapPair propPairs = new MapPair();
        private ListComboItems propComboItems = new ListComboItems();
        private DBInfo propDbInfo = new DBInfo();
        private UTF8Encoding encode = new UTF8Encoding(false);
        private XmlSerializer serializer1=null,serializer2,serializer3 = null;
        private string strConfigPath1=string.Empty;
        private string strConfigPath2=string.Empty;
        private string strConfigPath3 = string.Empty;


        /******************************************************
        *   ★ プロパティ： 設定ファイル書き込み --[ 設定のみ ] ★
        *******************************************************/
        public string ConfigPath
        {
            set {
                string strwoExt = Path.GetFileNameWithoutExtension(value);
                strConfigPath1 = string.Format("{0}.xml", strwoExt);
                strConfigPath2 = string.Format("{0}_cmblist.xml", strwoExt);
                strConfigPath3 = string.Format("{0}_db_con.xml", strwoExt);
            }
        }


        /******************************************************
        *   ★ プロパティ： 設定ファイル1 取得 --[ 取得のみ ] ★
        *   ・テンプレート値の設定
        *******************************************************/
        public string ConfigPath1
        {
            get { return strConfigPath1==string.Empty?".\\defaultConfig.xml":strConfigPath1 ; }
        }

        /******************************************************
        *   ★ プロパティ： 設定ファイル2 取得 --[ 取得のみ ] ★
        *   ・コンボボックスの入力履歴
        *******************************************************/
        public string ConfigPath2
        {
            get { return strConfigPath2 == string.Empty ? ".\\defaultConfig_cmblist.xml" : strConfigPath2; }
        }

        /******************************************************
        *   ★ プロパティ： 設定ファイル3 取得 --[ 取得のみ ] ★
        *   ・データベース(Access)の設定
        *******************************************************/
        public string ConfigPath3
        {
            get { return strConfigPath3 == string.Empty ? ".\\defaultConfig_db_con.xml" : strConfigPath3; }
        }

        public MapPair Pairs { get { return propPairs; } }
        public ListComboItems ComboItems { get { return propComboItems; } }
        public DBInfo DatabaseInfo { get { return propDbInfo; } }

        public TemplateText()
        {
            serializer1 = new XmlSerializer(typeof(MapPair));
            serializer2 = new XmlSerializer(typeof(ListComboItems));
            serializer3 = new XmlSerializer(typeof(DBInfo));
        }

        /******************************************************
        *   設定ファイルへデータ保存
        *******************************************************/
        public void Serialize()
        {

            try {
                StreamWriter sw1 = new StreamWriter(ConfigPath1, false, encode);
                using (sw1)
                {
                    serializer1.Serialize(sw1, propPairs);
                }

                StreamWriter sw2 = new StreamWriter(ConfigPath2, false, encode);
                using (sw2)
                {
                    serializer2.Serialize(sw2, propComboItems);
                }
                StreamWriter sw3 = new StreamWriter(ConfigPath3, false, encode);
                using (sw3)
                {
                    serializer3.Serialize(sw3, propDbInfo);
                }
            }
            catch (Exception ex)
            {
                throw ex;  
            }
        }

        /******************************************************
        *   設定ファイルからデータ読み込み(結果はPairsとComboItemsを参照)
        *******************************************************/
        public void Deserialize()
        {
            try {
                StreamReader sr1 = new StreamReader(ConfigPath1);
                using (sr1)
                {
                    propPairs = (MapPair)serializer1.Deserialize(sr1);
                }
                StreamReader sr2 = new StreamReader(ConfigPath2);
                using (sr2)
                {
                    propComboItems = (ListComboItems)serializer2.Deserialize(sr2);
                }
                StreamReader sr3 = new StreamReader(ConfigPath3);
                using (sr3)
                {
                    propDbInfo = (DBInfo)serializer3.Deserialize(sr3);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }



}

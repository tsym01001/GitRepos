﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOSYU.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HOSYU.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ConnString {
            get {
                return ResourceManager.GetString("ConnString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   .\default.accdb に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Defaultdb {
            get {
                return ResourceManager.GetString("Defaultdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon hosyu {
            get {
                object obj = ResourceManager.GetObject("hosyu", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   INSERT INTO ACCEPTTABLE ( ACCEPTID, AREADATA, POSTDATA, ACCEPTDAYTIME, SYSNAM, SYMPTOM )
        ///SELECT &apos;{0}&apos; AS ACCEPTID, &apos;{1}&apos; AS AREADATA, &apos;{2}&apos; AS POSTDATA, &apos;{3}&apos; AS ACCEPTDAYTIME, &apos;{4}&apos; AS SYSNAM, &apos;{5}&apos; AS SYMPTOM
        ///FROM ACCEPTTABLE, AREATABLE INNER JOIN POSTTABLE ON AREATABLE.AREAID = POSTTABLE.AREAID; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string InsertAcceptTbl {
            get {
                return ResourceManager.GetString("InsertAcceptTbl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   INSERT INTO PDFTABLE ( ACCEPTID, PDFID, COMPDAYTIME, COMPFLUG, WORKER, CAUSE, DISPOSAL, INPUTS )
        ///SELECT &apos;{0}&apos; AS ACCEPTID, &apos;{1}&apos; AS PDFID, &apos;{2}&apos; AS COMPDAYTIME, &apos;{3}&apos; AS COMPFLUG, &apos;{4}&apos; AS WORKER, &apos;{5}&apos; AS CAUSE, &apos;{6}&apos; AS DISPOSAL, &apos;{7}&apos; AS INPUTS
        ///FROM INPUTSTABLE, WORKERTABLE, ACCEPTTABLE INNER JOIN PDFTABLE ON ACCEPTTABLE.ACCEPTID = PDFTABLE.ACCEPTID
        ///WHERE (([ACCEPTTABLE].[ACCEPTID]=[PDFTABLE].[ACCEPTID])); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string InsertPdfTab {
            get {
                return ResourceManager.GetString("InsertPdfTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   INSERT INTO REPORTTABLE ( ACCEPTID, REPORTID, CONTACTDAYTIME, REPORTMSG, INPUTS )
        ///SELECT &apos;{0}&apos; AS ACCEPTID, &apos;{1}&apos; AS REPORTID, &apos;{2}&apos; AS CONTACTDAYTIME, &apos;{3}&apos; AS REPORTMSG, &apos;{4}&apos; AS INPUTS
        ///FROM REPORTTABLE
        ///WHERE (([REPORTTABLE].[ACCEPTID]=[ACCEPTTABLE].[ACCEPTID])); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string InsertReportTab {
            get {
                return ResourceManager.GetString("InsertReportTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] KenkeiHosyu {
            get {
                object obj = ResourceManager.GetObject("KenkeiHosyu", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   受付番号：|管轄：|部署：|受付日時：|システム名：|症状：|連絡日時：|報告：|入力担当：|完了日時：|担当：|原因：|処置：|出力データ： に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string LblKeys {
            get {
                return ResourceManager.GetString("LblKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|60|61|62|63|64|65|66|67|68|69|70|71|72|73|74|75|76|77|78|79|80|81|82|83|84|85|86|87|88|89|90|91|92|93|94|95|96|97|98|99 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string resDomID {
            get {
                return ResourceManager.GetString("resDomID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SELECT ACCEPTTABLE.ACCEPTID, AREATABLE.AREADATA, POSTTABLE.POSTDATA, ACCEPTTABLE.ACCEPTDAYTIME, ACCEPTTABLE.SYSNAM, ACCEPTTABLE.SYMPTOM
        ///FROM ACCEPTTABLE, AREATABLE INNER JOIN POSTTABLE ON AREATABLE.AREAID = POSTTABLE.AREAID
        ///WHERE ((AREATABLE.AREAID=&apos;{0}&apos;) And (POSTTABLE.POSTID=&apos;{1}&apos;)); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SelectAcceptTab {
            get {
                return ResourceManager.GetString("SelectAcceptTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SELECT PDFTABLE.ACCEPTID, PDFTABLE.PDFID, PDFTABLE.COMPDAYTIME, PDFTABLE.COMPFLUG, WORKERTABLE.WORKER, PDFTABLE.CAUSE, PDFTABLE.DISPOSAL, INPUTSTABLE.INPUTS
        ///FROM PDFTABLE, WORKERTABLE, INPUTSTABLE
        ///WHERE (([WORKERTABLE].[WORKERID]=&apos;{0}&apos;) AND ([INPUTSTABLE].[INPUTSID]=&apos;{1}&apos;)); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SelectPdfTab {
            get {
                return ResourceManager.GetString("SelectPdfTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SELECT REPORTTABLE.ACCEPTID, REPORTTABLE.REPORTID, REPORTTABLE.CONTACTDAYTIME, REPORTTABLE.REPORTMSG, INPUTSTABLE.INPUTS
        ///FROM REPORTTABLE, INPUTSTABLE
        ///WHERE (([INPUTSTABLE].[INPUTSID]=&apos;{0}&apos;)); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SelectReportTab {
            get {
                return ResourceManager.GetString("SelectReportTab", resourceCulture);
            }
        }
        
        /// <summary>
        ///   UPDATE ACCEPTTABLE SET ACCEPTTABLE.AREADATA = &apos;{1}&apos;, ACCEPTTABLE.POSTDATA = &apos;{2}&apos;, ACCEPTTABLE.ACCEPTDAYTIME = &apos;{3}&apos;, ACCEPTTABLE.SYSNAM = &apos;{4}&apos;, ACCEPTTABLE.SYMPTOM = &apos;{5}&apos;
        ///WHERE (((ACCEPTTABLE.ACCEPTID)=&apos;{0}&apos;)); に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UpdateAcceptTab {
            get {
                return ResourceManager.GetString("UpdateAcceptTab", resourceCulture);
            }
        }
    }
}

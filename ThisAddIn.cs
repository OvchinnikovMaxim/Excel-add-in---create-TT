using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ExcelAddIn1
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
        
        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            Ribbon1 ribbon = new Ribbon1();

            #region Обработчики событий для присвоения канала сбыта
            ribbon.Button_tt_set += Setev_ButtonClicked;
            ribbon.Button_tt_rozn += Rozn_ButtonClicked;
            ribbon.Button_tt_opt += Opt_ButtonClicked;
            ribbon.Button_tt_nek += Nek_ButtonClicked;
            ribbon.Button_tt_kash += Kash_ButtonClicked;
            ribbon.Button_tt_horeca += Horeca_ButtonClicked;
            #endregion

            #region Обработчики событий для присвоения типа магазина
            #region НБП, КЖК
            ribbon.Button_kgk_cash += Kgk_cash_ButtonClicked;
            ribbon.Button_kgk_nek += Kgk_nek_ButtonClicked;
            ribbon.Button_kgk_hor_rest += Kgk_hor_rest_ButtonClicked;
            ribbon.Button_kgk_hor_ot += Kgk_hor_ot_ButtonClicked;
            ribbon.Button_kgk_hor_kafe_bar += Kgk_hor_kafe_bar_ButtonClicked;
            ribbon.Button_kgk_hor_t_bistro_pit += Kgk_hor_t_bistro_pit_ButtonClicked;
            ribbon.Button_kgk_hor_obshepit += Kgk_hor_obshepit_ButtonClicked;
            ribbon.Button_kgk_hor_proizv += Kgk_hor_proizv_ButtonClicked;
            ribbon.Button_kgk_hor_bar += Kgk_hor_bar_ButtonClicked;
            ribbon.Button_kgk_hor_kafe += Kgk_hor_kafe_ButtonClicked;
            ribbon.Button_kgk_hor_stol += Kgk_hor_stol_ButtonClicked;
            ribbon.Button_kgk_hor_p_bistro_obs += Kgk_hor_p_bistro_obs_ButtonClicked;
            ribbon.Button_kgk_opt_kb += Kgk_opt_kb_ButtonClicked;
            ribbon.Button_kgk_opt_cash += Kgk_opt_cash_ButtonClicked;
            ribbon.Button_kgk_rozn_minimar += Kgk_rozn_minimar_ButtonClicked;
            ribbon.Button_kgk_rozn_apteka += Kgk_rozn_apteka_ButtonClicked;
            ribbon.Button_kgk_rozn_superm += Kgk_rozn_superm_ButtonClicked;
            ribbon.Button_kgk_rozn_dragstore += Kgk_rozn_dragstor_ButtonClicked;
            ribbon.Button_kgk_rozn_prilavok += Kgk_rozn_prilavok_ButtonClicked;
            ribbon.Button_kgk_rozn_t_rynok += Kgk_rozn_t_rynok_ButtonClicked;
            ribbon.Button_kgk_rozn_hozmag += Kgk_rozn_hozmag_ButtonClicked;
            ribbon.Button_kgk_rozn_nek += Kgk_rozn_nek_ButtonClicked;
            ribbon.Button_kgk_rozn_cash += Kgk_rozn_cash_ButtonClicked;
            ribbon.Button_kgk_rozn_pav += Kgk_rozn_pav_ButtonClicked;
            ribbon.Button_kgk_set_c_c += Kgk_set_c_c_ButtonClicked;
            ribbon.Button_kgk_set_giperm += Kgk_set_giperm_ButtonClicked;
            ribbon.Button_kgk_set_superm += Kgk_set_superm_ButtonClicked;
            ribbon.Button_kgk_set_minim += Kgk_set_minim_ButtonClicked;
            ribbon.Button_kgk_set_dragstore += Kgk_set_dragstore_ButtonClicked;
            ribbon.Button_kgk_set_rc += Kgk_set_rc_ButtonClicked;
            ribbon.Button_kgk_set_mag_pril += Kgk_set_mag_pril_ButtonClicked;
            ribbon.Button_kgk_set_ofis += Kgk_set_ofis_ButtonClicked;
            #endregion
            #region НК
            ribbon.Button_nk_nek += Nk_nek_ButtonClicked;
            ribbon.Button_nk_cash += Nk_cash_ButtonClicked;
            ribbon.Button_nk_opt_kb += Nk_opt_kb_ButtonClicked;
            ribbon.Button_nk_opt_cash += Nk_opt_cash_ButtonClicked;
            ribbon.Button_nk_rozn_pril_spec += Nk_rozn_pril_spec_ButtonClicked;
            ribbon.Button_nk_rozn_pril_prod += Nk_rozn_pril_prod_ButtonClicked;
            ribbon.Button_nk_rozn_kont_spec += Nk_rozn_kont_spec_ButtonClicked;
            ribbon.Button_nk_rozn_pril_hozt += Nk_rozn_pril_hozt_ButtonClicked;
            ribbon.Button_nk_rozn_pavilion += Nk_rozn_pavilion_ButtonClicked;
            ribbon.Button_nk_rozn_sam_mal += Nk_rozn_sam_mal_ButtonClicked;
            ribbon.Button_nk_rozn_apteka += Nk_rozn_apteka_ButtonClicked;
            ribbon.Button_nk_rozn_sam_bol += Nk_rozn_sam_bol_ButtonClicked;
            ribbon.Button_nk_set_dragstore += Nk_set_dragstore_ButtonClicked;
            ribbon.Button_nk_set_rc += Nk_set_rc_ButtonClicked;
            ribbon.Button_nk_set_mag_pril += Nk_set_mag_pril_ButtonClicked;
            ribbon.Button_nk_set_c_c += Nk_set_c_c_ButtonClicked;
            ribbon.Button_nk_set_giperm += Nk_set_giperm_ButtonClicked;
            ribbon.Button_nk_set_superm += Nk_set_superm_ButtonClicked;
            ribbon.Button_nk_set_minim += Nk_set_minim_ButtonClicked;
            ribbon.Button_nk_set_ofis += Nk_set_ofis_ButtonClicked;
            ribbon.Button_nk_set_detmag += Nk_set_detmag_ButtonClicked;
            ribbon.Button_nk_set_apteka += Nk_set_apteka_ButtonClicked;
            ribbon.Button_nk_set_discounter += Nk_set_discounter_ButtonClicked;
            ribbon.Button_nk_set_inet += Nk_set_inet_ButtonClicked;
            ribbon.Button_nk_set_stroy += Nk_set_stroy_ButtonClicked;  
            #endregion
            #endregion

            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new IRibbonExtension[]{ ribbon });
        }

        /// <summary>
        /// Внесение информации в выбранные ячейки
        /// </summary>
        /// <param name="t"></param>
        public void Text_selectCells(int t)
        {
            Excel.Window W = this.Application.ActiveWindow;
            W.RangeSelection.Cells.Value = t.ToString();
        }

        #region каналы сбыта
        private void Setev_ButtonClicked() => Text_selectCells(1);
        private void Rozn_ButtonClicked() => Text_selectCells(2);
        private void Opt_ButtonClicked() => Text_selectCells(3);
        private void Nek_ButtonClicked() => Text_selectCells(4);
        private void Kash_ButtonClicked() => Text_selectCells(5);
        private void Horeca_ButtonClicked() => Text_selectCells(6);
        #endregion

        #region типы магазинов
        #region НБП, КЖК
        private void Kgk_cash_ButtonClicked() => Text_selectCells(17);
        private void Kgk_nek_ButtonClicked() => Text_selectCells(8);
        private void Kgk_hor_rest_ButtonClicked() => Text_selectCells(31);
        private void Kgk_hor_ot_ButtonClicked() => Text_selectCells(30);
        private void Kgk_hor_kafe_bar_ButtonClicked() => Text_selectCells(32);
        private void Kgk_hor_t_bistro_pit_ButtonClicked() => Text_selectCells(33);
        private void Kgk_hor_obshepit_ButtonClicked() => Text_selectCells(35);
        private void Kgk_hor_proizv_ButtonClicked() => Text_selectCells(36);
        private void Kgk_hor_bar_ButtonClicked() => Text_selectCells(149);
        private void Kgk_hor_kafe_ButtonClicked() => Text_selectCells(150);
        private void Kgk_hor_stol_ButtonClicked() => Text_selectCells(151);
        private void Kgk_hor_p_bistro_obs_ButtonClicked() => Text_selectCells(152);
        private void Kgk_opt_kb_ButtonClicked() => Text_selectCells(46);
        private void Kgk_opt_cash_ButtonClicked() => Text_selectCells(45);
        private void Kgk_rozn_minimar_ButtonClicked() => Text_selectCells(9);
        private void Kgk_rozn_apteka_ButtonClicked() => Text_selectCells(11);
        private void Kgk_rozn_superm_ButtonClicked() => Text_selectCells(25);
        private void Kgk_rozn_dragstor_ButtonClicked() => Text_selectCells(38);
        private void Kgk_rozn_prilavok_ButtonClicked() => Text_selectCells(39);
        private void Kgk_rozn_t_rynok_ButtonClicked() => Text_selectCells(40);
        private void Kgk_rozn_hozmag_ButtonClicked() => Text_selectCells(41);
        private void Kgk_rozn_nek_ButtonClicked() => Text_selectCells(42);
        private void Kgk_rozn_cash_ButtonClicked() => Text_selectCells(46);
        private void Kgk_rozn_pav_ButtonClicked() => Text_selectCells(44);
        private void Kgk_set_c_c_ButtonClicked() => Text_selectCells(4);
        private void Kgk_set_giperm_ButtonClicked() => Text_selectCells(5);
        private void Kgk_set_superm_ButtonClicked() => Text_selectCells(6);
        private void Kgk_set_minim_ButtonClicked() => Text_selectCells(21);
        private void Kgk_set_dragstore_ButtonClicked() => Text_selectCells(29);
        private void Kgk_set_rc_ButtonClicked() => Text_selectCells(34);
        private void Kgk_set_mag_pril_ButtonClicked() => Text_selectCells(37);
        private void Kgk_set_ofis_ButtonClicked() => Text_selectCells(153);
        #endregion
        #region НК
        private void Nk_nek_ButtonClicked() => Text_selectCells(68);
        private void Nk_cash_ButtonClicked() => Text_selectCells(71);
        private void Nk_opt_kb_ButtonClicked() => Text_selectCells(64);
        private void Nk_opt_cash_ButtonClicked() => Text_selectCells(63);
        private void Nk_rozn_pril_spec_ButtonClicked() => Text_selectCells(56);
        private void Nk_rozn_pril_prod_ButtonClicked() => Text_selectCells(57);
        private void Nk_rozn_kont_spec_ButtonClicked() => Text_selectCells(58);
        private void Nk_rozn_pril_hozt_ButtonClicked() => Text_selectCells(59);
        private void Nk_rozn_pavilion_ButtonClicked() => Text_selectCells(62);
        private void Nk_rozn_sam_mal_ButtonClicked() => Text_selectCells(69);
        private void Nk_rozn_apteka_ButtonClicked() => Text_selectCells(70);
        private void Nk_rozn_sam_bol_ButtonClicked() => Text_selectCells(73);
        private void Nk_set_dragstore_ButtonClicked() => Text_selectCells(47);
        private void Nk_set_rc_ButtonClicked() => Text_selectCells(52);
        private void Nk_set_mag_pril_ButtonClicked() => Text_selectCells(55);
        private void Nk_set_c_c_ButtonClicked() => Text_selectCells(65);
        private void Nk_set_giperm_ButtonClicked() => Text_selectCells(66);
        private void Nk_set_superm_ButtonClicked() => Text_selectCells(67);
        private void Nk_set_minim_ButtonClicked() => Text_selectCells(72);
        private void Nk_set_ofis_ButtonClicked() => Text_selectCells(147);
        private void Nk_set_detmag_ButtonClicked() => Text_selectCells(154);
        private void Nk_set_apteka_ButtonClicked() => Text_selectCells(155);
        private void Nk_set_discounter_ButtonClicked() => Text_selectCells(157);
        private void Nk_set_inet_ButtonClicked() => Text_selectCells(158);
        private void Nk_set_stroy_ButtonClicked() => Text_selectCells(159);
        #endregion 
        #endregion
    }
}

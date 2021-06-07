using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {
        #region Объявление делегатов событий для каналов сбыта
        public event Action Button_tt_set;
        public event Action Button_tt_rozn;
        public event Action Button_tt_opt;
        public event Action Button_tt_nek;
        public event Action Button_tt_kash;
        public event Action Button_tt_horeca;
        #endregion

        #region Объявление делегатов событий для типов магазинов
        #region НБП,КЖК
        public event Action Button_kgk_cash;
        public event Action Button_kgk_nek;
        public event Action Button_kgk_hor_rest;
        public event Action Button_kgk_hor_ot;
        public event Action Button_kgk_hor_kafe_bar;
        public event Action Button_kgk_hor_t_bistro_pit;
        public event Action Button_kgk_hor_obshepit;
        public event Action Button_kgk_hor_proizv;
        public event Action Button_kgk_hor_bar;
        public event Action Button_kgk_hor_kafe;
        public event Action Button_kgk_hor_stol;
        public event Action Button_kgk_hor_p_bistro_obs;
        public event Action Button_kgk_opt_kb;
        public event Action Button_kgk_opt_cash;
        public event Action Button_kgk_rozn_minimar;
        public event Action Button_kgk_rozn_apteka;
        public event Action Button_kgk_rozn_superm;
        public event Action Button_kgk_rozn_dragstore;
        public event Action Button_kgk_rozn_prilavok;
        public event Action Button_kgk_rozn_t_rynok;
        public event Action Button_kgk_rozn_hozmag;
        public event Action Button_kgk_rozn_nek;
        public event Action Button_kgk_rozn_cash;
        public event Action Button_kgk_rozn_pav;
        public event Action Button_kgk_set_c_c;
        public event Action Button_kgk_set_giperm;
        public event Action Button_kgk_set_superm;
        public event Action Button_kgk_set_minim;
        public event Action Button_kgk_set_dragstore;
        public event Action Button_kgk_set_rc;
        public event Action Button_kgk_set_mag_pril;
        public event Action Button_kgk_set_ofis; 
        #endregion

        #region НК
        public event Action Button_nk_nek;
        public event Action Button_nk_cash;
        public event Action Button_nk_opt_kb;
        public event Action Button_nk_opt_cash;
        public event Action Button_nk_rozn_pril_spec;
        public event Action Button_nk_rozn_pril_prod;
        public event Action Button_nk_rozn_kont_spec;
        public event Action Button_nk_rozn_pril_hozt;
        public event Action Button_nk_rozn_pavilion;
        public event Action Button_nk_rozn_sam_mal;
        public event Action Button_nk_rozn_apteka;
        public event Action Button_nk_rozn_sam_bol;
        public event Action Button_nk_set_dragstore;
        public event Action Button_nk_set_rc;
        public event Action Button_nk_set_mag_pril;
        public event Action Button_nk_set_c_c;
        public event Action Button_nk_set_giperm;
        public event Action Button_nk_set_superm;
        public event Action Button_nk_set_minim;
        public event Action Button_nk_set_ofis;
        public event Action Button_nk_set_detmag;
        public event Action Button_nk_set_apteka;
        public event Action Button_nk_set_discounter;
        public event Action Button_nk_set_inet;
        public event Action Button_nk_set_stroy;  
        #endregion
        #endregion

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }
                
        private void combo_zavod_TextChanged(object sender, RibbonControlEventArgs e)
        {
            switch (combo_zavod.Text)
            {
                case "НК":
                    switch (combo_category.Text)
                    {
                        case "Сетевой":
                            Visible_TT_Type();
                            Visible_TT_NK_Set(true);
                            break;
                        case "Розничный":
                            Visible_TT_Type();
                            Visible_TT_NK_Rozn(true);
                            break;
                        case "Оптовый":
                            Visible_TT_Type();
                            btn_nk_opt_cash.Visible = true;
                            btn_nk_opt_kb.Visible = true;
                            break;
                        case "Некоммерческий":
                            Visible_TT_Type();
                            btn_nk_nek.Visible = true;
                            break;
                        case "КЭШ дистрибьютора":
                            Visible_TT_Type();
                            btn_nk_cash.Visible = true;
                            break;
                        case "HoReCa":
                            Visible_TT_Type();
                            break;
                        default:
                            break;
                    }
                    break;
                case "НБП,КЖК":
                    switch (combo_category.Text)
                    {
                        case "Сетевой":
                            Visible_TT_Type();
                            Visible_TT_KGK_Set(true);
                            break;
                        case "Розничный":
                            Visible_TT_Type();
                            Visible_TT_KGK_Rozn(true);
                            break;
                        case "Оптовый":
                            Visible_TT_Type();
                            btn_kgk_opt_cash.Visible = true;
                            btn_kgk_opt_kb.Visible = true;
                            break;
                        case "Некоммерческий":
                            Visible_TT_Type();
                            btn_kgk_nek.Visible = true;
                            break;
                        case "КЭШ дистрибьютора":
                            Visible_TT_Type();
                            btn_kgk_cash.Visible = true;
                            break;
                        case "HoReCa":
                            Visible_TT_Type();
                            Visible_TT_KGK_Horeca(true);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void combo_category_TextChanged(object sender, RibbonControlEventArgs e)
        {
            string zavod = combo_zavod.Text;

            switch (combo_category.Text)
            {                
                case "Сетевой":
                    Visible_TT_Type();

                    if (zavod == "НК")
                        Visible_TT_NK_Set(true);

                    if (zavod == "НБП,КЖК")
                        Visible_TT_KGK_Set(true);
                    break;
                case "Розничный":
                    Visible_TT_Type();

                    if (zavod == "НК")
                        Visible_TT_NK_Rozn(true);

                    if (zavod == "НБП,КЖК")
                        Visible_TT_KGK_Rozn(true);
                    break;
                case "Оптовый":
                    Visible_TT_Type();

                    if (zavod == "НК")
                    {
                        btn_nk_opt_cash.Visible = true;
                        btn_nk_opt_kb.Visible = true;
                    }

                    if (zavod == "НБП,КЖК")
                    {
                        btn_kgk_opt_cash.Visible = true;
                        btn_kgk_opt_kb.Visible = true;
                    }
                    break;
                case "Некоммерческий":
                    Visible_TT_Type();

                    if (zavod == "НК")
                        btn_nk_nek.Visible = true;

                    if (zavod == "НБП,КЖК")
                        btn_kgk_nek.Visible = true;
                    break;
                case "КЭШ дистрибьютора":
                    Visible_TT_Type();

                    if (zavod == "НК")
                        btn_nk_cash.Visible = true;

                    if (zavod == "НБП,КЖК")
                        btn_kgk_cash.Visible = true;
                    break;
                case "HoReCa":
                    Visible_TT_Type();

                    if (zavod == "НБП,КЖК")
                        Visible_TT_KGK_Horeca(true);  
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// скрыть типы документов
        /// </summary>
        public void Visible_TT_Type()
        {
            btn_kgk_cash.Visible = false;  //17
            btn_kgk_nek.Visible = false;   //8

            Visible_TT_KGK_Horeca(false);

            btn_kgk_opt_cash.Visible = false; //45
            btn_kgk_opt_kb.Visible = false;   //46

            Visible_TT_KGK_Rozn(false);

            Visible_TT_KGK_Set(false);

            btn_nk_nek.Visible = false;    //68
            btn_nk_cash.Visible = false;   //71

            btn_nk_opt_cash.Visible = false;// 63
            btn_nk_opt_kb.Visible = false;  // 64

            Visible_TT_NK_Rozn(false);

            Visible_TT_NK_Set(false);
        }

        #region Сетевой, розничный, horeca КЖК
        /// <summary>
        /// Видимость типов торговых точек канала Horeca КЖК
        /// </summary>
        /// <param name="vis">false - невидимо, true - видимо</param>
        public void Visible_TT_KGK_Horeca(bool vis)
        {
            btn_kgk_hor_rest.Visible = vis;         // 31
            btn_kgk_hor_ot.Visible = vis;           // 30
            btn_kgk_hor_kafe_bar.Visible = vis;     // 32
            btn_kgk_hor_t_bistro_pit.Visible = vis; // 33
            btn_kgk_hor_obshepit.Visible = vis;     // 35
            btn_kgk_hor_proizv.Visible = vis;       // 36
            btn_kgk_hor_bar.Visible = vis;          // 149
            btn_kgk_hor_kafe.Visible = vis;         // 150
            btn_kgk_hor_stol.Visible = vis;         // 151
            btn_kgk_hor_p_bistro_obs.Visible = vis; // 152
        }

        /// <summary>
        /// Видимость типов торговых точек канала Розничный КЖК
        /// </summary>
        /// <param name="vis">false - невидимо, true - видимо</param>
        public void Visible_TT_KGK_Rozn(bool vis)
        {
            btn_kgk_rozn_minimar.Visible = vis;   // 9
            btn_kgk_rozn_apteka.Visible = vis;    // 11
            btn_kgk_rozn_superm.Visible = vis;    // 25
            btn_kgk_rozn_dragstore.Visible = vis; // 38
            btn_kgk_rozn_prilavok.Visible = vis;  // 39
            btn_kgk_rozn_t_rynok.Visible = vis;   // 40
            btn_kgk_rozn_hozmag.Visible = vis;    // 41
            btn_kgk_rozn_nek.Visible = vis;       // 42
            btn_kgk_rozn_cash.Visible = vis;      // 43
            btn_kgk_rozn_pav.Visible = vis;       // 44
        }

        /// <summary>
        /// Видимость типов торговых точек канала Сетевой КЖК
        /// </summary>
        /// <param name="vis">false - невидимо, true - видимо</param>
        public void Visible_TT_KGK_Set(bool vis)
        {
            btn_kgk_set_c_c.Visible = vis;        // 4
            btn_kgk_set_giperm.Visible = vis;     // 5
            btn_kgk_set_superm.Visible = vis;     // 6
            btn_kgk_set_minim.Visible = vis;      // 21
            btn_kgk_set_dragstore.Visible = vis;  // 29
            btn_kgk_set_rc.Visible = vis;         // 34
            btn_kgk_set_mag_pril.Visible = vis;   // 37
            btn_kgk_set_ofis.Visible = vis;       // 153
        }
        #endregion

        #region Сетевой, розничный НК
        /// <summary>
        /// Видимость типов торговых точек канала Розничный НК
        /// </summary>
        /// <param name="vis">false - невидимо, true - видимо</param>
        public void Visible_TT_NK_Rozn(bool vis)
        {
            btn_nk_rozn_pril_spec.Visible = vis; // 56
            btn_nk_rozn_pril_prod.Visible = vis; // 57
            btn_nk_rozn_kont_spec.Visible = vis; // 58
            btn_nk_rozn_pril_hozt.Visible = vis; // 59
            btn_nk_rozn_pavilion.Visible = vis;  // 62
            btn_nk_rozn_sam_mal.Visible = vis;   // 69
            btn_nk_rozn_apteka.Visible = vis;    // 70
            btn_nk_rozn_sam_bol.Visible = vis;   // 73
        }

        /// <summary>
        /// Видимость типов торговых точек канала Сетевой НК
        /// </summary>
        /// <param name="vis">false - невидимо, true - видимо</param>
        public void Visible_TT_NK_Set(bool vis)
        {
            btn_nk_set_dragstore.Visible = vis;  // 47
            btn_nk_set_rc.Visible = vis;         // 52
            btn_nk_set_mag_pril.Visible = vis;   // 55
            btn_nk_set_c_c.Visible = vis;        // 65
            btn_nk_set_giperm.Visible = vis;     // 66
            btn_nk_set_superm.Visible = vis;     // 67
            btn_nk_set_minim.Visible = vis;      // 72
            btn_nk_set_ofis.Visible = vis;       // 147
            btn_nk_set_detmag.Visible = vis;     // 154
            btn_nk_set_apteka.Visible = vis;     // 155
            btn_nk_set_discounter.Visible = vis; // 157
            btn_nk_set_inet.Visible = vis;       // 158
            btn_nk_set_stroy.Visible = vis;      // 159
        }
        #endregion

        #region канал сбыта
        /// <summary>
        /// Сетевой канал сбыта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_set_Click(object sender, RibbonControlEventArgs e) => Button_tt_set?.Invoke();

        /// <summary>
        /// Розничный канал сбыта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_rozn_Click(object sender, RibbonControlEventArgs e) => Button_tt_rozn?.Invoke();

        /// <summary>
        /// Оптовый канал сбыта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_opt_Click(object sender, RibbonControlEventArgs e) => Button_tt_opt?.Invoke();

        /// <summary>
        /// Некоммерческий канал сбыта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_nek_Click(object sender, RibbonControlEventArgs e) => Button_tt_nek?.Invoke();

        /// <summary>
        /// КЭШ дистрибьютора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_kash_Click(object sender, RibbonControlEventArgs e) => Button_tt_kash?.Invoke();

        /// <summary>
        /// HoReCa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_tt_horeca_Click(object sender, RibbonControlEventArgs e) => Button_tt_horeca?.Invoke();

        #endregion

        #region типы магазинов
        #region НК - Сетевой
        private void Btn_nk_set_dragstore_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_dragstore?.Invoke();

        private void Btn_nk_set_rc_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_rc?.Invoke();

        private void Btn_nk_set_mag_pril_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_mag_pril?.Invoke();

        private void Btn_nk_set_c_c_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_c_c?.Invoke();

        private void Btn_nk_set_giperm_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_giperm?.Invoke();

        private void Btn_nk_set_superm_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_superm?.Invoke();

        private void Btn_nk_set_minim_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_minim?.Invoke();

        private void Btn_nk_set_ofis_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_ofis?.Invoke();

        private void Btn_nk_set_detmag_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_detmag?.Invoke();

        private void Btn_nk_set_apteka_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_apteka?.Invoke();

        private void Btn_nk_set_discounter_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_discounter?.Invoke();

        private void Btn_nk_set_inet_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_inet?.Invoke();

        private void Btn_nk_set_stroy_Click(object sender, RibbonControlEventArgs e) => Button_nk_set_stroy?.Invoke();
        #endregion

        #region НК - Розничный
        private void Btn_nk_rozn_pril_spec_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_pril_spec?.Invoke();

        private void Btn_nk_rozn_pril_prod_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_pril_prod?.Invoke();

        private void Btn_nk_rozn_kont_spec_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_kont_spec?.Invoke();

        private void Btn_nk_rozn_pril_hozt_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_pril_hozt?.Invoke();

        private void Btn_nk_rozn_pavilion_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_pavilion?.Invoke();

        private void Btn_nk_rozn_sam_mal_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_sam_mal?.Invoke();

        private void Btn_nk_rozn_apteka_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_apteka?.Invoke();

        private void Btn_nk_rozn_sam_bol_Click(object sender, RibbonControlEventArgs e) => Button_nk_rozn_sam_bol?.Invoke();
        #endregion

        #region НК - Оптовый, некоммерческий, КЭШ дистрибьютора
        private void Btn_nk_opt_kb_Click(object sender, RibbonControlEventArgs e) => Button_nk_opt_kb?.Invoke();

        private void Btn_nk_opt_cash_Click(object sender, RibbonControlEventArgs e) => Button_nk_opt_cash?.Invoke();

        private void Btn_nk_nek_Click(object sender, RibbonControlEventArgs e) => Button_nk_nek?.Invoke();

        private void Btn_nk_cash_Click(object sender, RibbonControlEventArgs e) => Button_nk_cash?.Invoke();
        #endregion

        #region КЖК - Сетевой
        private void Btn_kgk_set_c_c_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_c_c?.Invoke();

        private void Btn_kgk_set_giperm_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_giperm?.Invoke();

        private void Btn_kgk_set_superm_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_superm?.Invoke();

        private void Btn_kgk_set_minim_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_minim?.Invoke();

        private void Btn_kgk_set_dragstore_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_dragstore?.Invoke();

        private void Btn_kgk_set_rc_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_rc?.Invoke();

        private void Btn_kgk_set_mag_pril_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_mag_pril?.Invoke();

        private void Btn_kgk_set_ofis_Click(object sender, RibbonControlEventArgs e) => Button_kgk_set_ofis?.Invoke();
        #endregion

        #region КЖК - Horeca
        private void Btn_kgk_hor_rest_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_rest?.Invoke();

        private void Btn_kgk_hor_ot_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_ot?.Invoke();

        private void Btn_kgk_hor_kafe_bar_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_kafe_bar?.Invoke();

        private void Btn_kgk_hor_t_bistro_pit_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_t_bistro_pit?.Invoke();

        private void Btn_kgk_hor_obshepit_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_obshepit?.Invoke();

        private void Btn_kgk_hor_proizv_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_proizv?.Invoke();

        private void Btn_kgk_hor_bar_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_bar?.Invoke();

        private void Btn_kgk_hor_kafe_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_kafe?.Invoke();

        private void Btn_kgk_hor_stol_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_stol?.Invoke();

        private void Btn_kgk_hor_p_bistro_obs_Click(object sender, RibbonControlEventArgs e) => Button_kgk_hor_p_bistro_obs?.Invoke();
        #endregion

        #region КЖК - Оптовый, КЭШ дистрибьютора, некоммерческий
        private void Btn_kgk_opt_kb_Click(object sender, RibbonControlEventArgs e) => Button_kgk_opt_kb?.Invoke();

        private void Btn_kgk_opt_cash_Click(object sender, RibbonControlEventArgs e) => Button_kgk_opt_cash?.Invoke();

        private void Btn_kgk_cash_Click(object sender, RibbonControlEventArgs e) => Button_kgk_cash?.Invoke();

        private void Btn_kgk_nek_Click(object sender, RibbonControlEventArgs e) => Button_kgk_nek?.Invoke();
        #endregion

        #region КЖК - Розничный
        private void Btn_kgk_rozn_minimar_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_minimar?.Invoke();

        private void Btn_kgk_rozn_apteka_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_apteka?.Invoke();

        private void Btn_kgk_rozn_superm_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_superm?.Invoke();

        private void Btn_kgk_rozn_dragstore_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_dragstore?.Invoke();

        private void Btn_kgk_rozn_prilavok_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_prilavok?.Invoke();

        private void Btn_kgk_rozn_t_rynok_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_t_rynok?.Invoke();

        private void Btn_kgk_rozn_hozmag_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_hozmag?.Invoke();

        private void Btn_kgk_rozn_nek_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_nek?.Invoke();

        private void Btn_kgk_rozn_cash_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_cash?.Invoke();

        private void Btn_kgk_rozn_pav_Click(object sender, RibbonControlEventArgs e) => Button_kgk_rozn_pav?.Invoke();
        #endregion
        #endregion
    }
}

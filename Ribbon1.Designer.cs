
namespace ExcelAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.gp_category = this.Factory.CreateRibbonGroup();
            this.btn_tt_set = this.Factory.CreateRibbonButton();
            this.btn_tt_rozn = this.Factory.CreateRibbonButton();
            this.btn_tt_opt = this.Factory.CreateRibbonButton();
            this.btn_tt_nek = this.Factory.CreateRibbonButton();
            this.btn_tt_kash = this.Factory.CreateRibbonButton();
            this.btn_tt_horeca = this.Factory.CreateRibbonButton();
            this.gp_cat_type = this.Factory.CreateRibbonGroup();
            this.combo_zavod = this.Factory.CreateRibbonComboBox();
            this.combo_category = this.Factory.CreateRibbonComboBox();
            this.gp_tt_type = this.Factory.CreateRibbonGroup();
            this.btn_nk_set_dragstore = this.Factory.CreateRibbonButton();
            this.btn_nk_set_rc = this.Factory.CreateRibbonButton();
            this.btn_nk_set_mag_pril = this.Factory.CreateRibbonButton();
            this.btn_nk_set_c_c = this.Factory.CreateRibbonButton();
            this.btn_nk_set_giperm = this.Factory.CreateRibbonButton();
            this.btn_nk_set_superm = this.Factory.CreateRibbonButton();
            this.btn_nk_set_minim = this.Factory.CreateRibbonButton();
            this.btn_nk_set_ofis = this.Factory.CreateRibbonButton();
            this.btn_nk_set_detmag = this.Factory.CreateRibbonButton();
            this.btn_nk_set_apteka = this.Factory.CreateRibbonButton();
            this.btn_nk_set_discounter = this.Factory.CreateRibbonButton();
            this.btn_nk_set_inet = this.Factory.CreateRibbonButton();
            this.btn_nk_set_stroy = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_pril_spec = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_pril_prod = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_kont_spec = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_pril_hozt = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_pavilion = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_sam_mal = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_apteka = this.Factory.CreateRibbonButton();
            this.btn_nk_rozn_sam_bol = this.Factory.CreateRibbonButton();
            this.btn_nk_opt_kb = this.Factory.CreateRibbonButton();
            this.btn_nk_opt_cash = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_c_c = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_giperm = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_superm = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_minim = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_dragstore = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_rc = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_mag_pril = this.Factory.CreateRibbonButton();
            this.btn_kgk_set_ofis = this.Factory.CreateRibbonButton();
            this.btn_nk_nek = this.Factory.CreateRibbonButton();
            this.btn_nk_cash = this.Factory.CreateRibbonButton();
            this.btn_kgk_cash = this.Factory.CreateRibbonButton();
            this.btn_kgk_nek = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_rest = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_ot = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_kafe_bar = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_t_bistro_pit = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_obshepit = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_proizv = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_bar = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_kafe = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_stol = this.Factory.CreateRibbonButton();
            this.btn_kgk_hor_p_bistro_obs = this.Factory.CreateRibbonButton();
            this.btn_kgk_opt_kb = this.Factory.CreateRibbonButton();
            this.btn_kgk_opt_cash = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_minimar = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_apteka = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_superm = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_dragstore = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_prilavok = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_t_rynok = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_hozmag = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_nek = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_cash = this.Factory.CreateRibbonButton();
            this.btn_kgk_rozn_pav = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.gp_category.SuspendLayout();
            this.gp_cat_type.SuspendLayout();
            this.gp_tt_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.gp_category);
            this.tab1.Groups.Add(this.gp_cat_type);
            this.tab1.Groups.Add(this.gp_tt_type);
            this.tab1.Label = "Заведение ТТ";
            this.tab1.Name = "tab1";
            // 
            // gp_category
            // 
            this.gp_category.Items.Add(this.btn_tt_set);
            this.gp_category.Items.Add(this.btn_tt_rozn);
            this.gp_category.Items.Add(this.btn_tt_opt);
            this.gp_category.Items.Add(this.btn_tt_nek);
            this.gp_category.Items.Add(this.btn_tt_kash);
            this.gp_category.Items.Add(this.btn_tt_horeca);
            this.gp_category.Label = "Канал сбыта";
            this.gp_category.Name = "gp_category";
            // 
            // btn_tt_set
            // 
            this.btn_tt_set.Label = "Сетевой";
            this.btn_tt_set.Name = "btn_tt_set";
            this.btn_tt_set.Tag = "1";
            this.btn_tt_set.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_set_Click);
            // 
            // btn_tt_rozn
            // 
            this.btn_tt_rozn.Label = "Розничный";
            this.btn_tt_rozn.Name = "btn_tt_rozn";
            this.btn_tt_rozn.Tag = "2";
            this.btn_tt_rozn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_rozn_Click);
            // 
            // btn_tt_opt
            // 
            this.btn_tt_opt.Label = "Оптовый";
            this.btn_tt_opt.Name = "btn_tt_opt";
            this.btn_tt_opt.Tag = "3";
            this.btn_tt_opt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_opt_Click);
            // 
            // btn_tt_nek
            // 
            this.btn_tt_nek.Label = "Некоммерческий";
            this.btn_tt_nek.Name = "btn_tt_nek";
            this.btn_tt_nek.Tag = "4";
            this.btn_tt_nek.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_nek_Click);
            // 
            // btn_tt_kash
            // 
            this.btn_tt_kash.Label = "КЭШ дистрибьютора";
            this.btn_tt_kash.Name = "btn_tt_kash";
            this.btn_tt_kash.Tag = "5";
            this.btn_tt_kash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_kash_Click);
            // 
            // btn_tt_horeca
            // 
            this.btn_tt_horeca.Label = "HoReCa";
            this.btn_tt_horeca.Name = "btn_tt_horeca";
            this.btn_tt_horeca.Tag = "6";
            this.btn_tt_horeca.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_tt_horeca_Click);
            // 
            // gp_cat_type
            // 
            this.gp_cat_type.Items.Add(this.combo_zavod);
            this.gp_cat_type.Items.Add(this.combo_category);
            this.gp_cat_type.Label = "Канал сбыта и завод";
            this.gp_cat_type.Name = "gp_cat_type";
            // 
            // combo_zavod
            // 
            ribbonDropDownItemImpl1.Label = "НК";
            ribbonDropDownItemImpl2.Label = "НБП,КЖК";
            this.combo_zavod.Items.Add(ribbonDropDownItemImpl1);
            this.combo_zavod.Items.Add(ribbonDropDownItemImpl2);
            this.combo_zavod.Label = "Завод";
            this.combo_zavod.Name = "combo_zavod";
            this.combo_zavod.Text = null;
            this.combo_zavod.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.combo_zavod_TextChanged);
            // 
            // combo_category
            // 
            ribbonDropDownItemImpl3.Label = "Сетевой";
            ribbonDropDownItemImpl4.Label = "Розничный";
            ribbonDropDownItemImpl5.Label = "Оптовый";
            ribbonDropDownItemImpl6.Label = "Некоммерческий";
            ribbonDropDownItemImpl7.Label = "КЭШ дистрибьютора";
            ribbonDropDownItemImpl8.Label = "HoReCa";
            this.combo_category.Items.Add(ribbonDropDownItemImpl3);
            this.combo_category.Items.Add(ribbonDropDownItemImpl4);
            this.combo_category.Items.Add(ribbonDropDownItemImpl5);
            this.combo_category.Items.Add(ribbonDropDownItemImpl6);
            this.combo_category.Items.Add(ribbonDropDownItemImpl7);
            this.combo_category.Items.Add(ribbonDropDownItemImpl8);
            this.combo_category.Label = "Канал сбыта";
            this.combo_category.Name = "combo_category";
            this.combo_category.Text = null;
            this.combo_category.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.combo_category_TextChanged);
            // 
            // gp_tt_type
            // 
            this.gp_tt_type.Items.Add(this.btn_nk_set_dragstore);
            this.gp_tt_type.Items.Add(this.btn_nk_set_rc);
            this.gp_tt_type.Items.Add(this.btn_nk_set_mag_pril);
            this.gp_tt_type.Items.Add(this.btn_nk_set_c_c);
            this.gp_tt_type.Items.Add(this.btn_nk_set_giperm);
            this.gp_tt_type.Items.Add(this.btn_nk_set_superm);
            this.gp_tt_type.Items.Add(this.btn_nk_set_minim);
            this.gp_tt_type.Items.Add(this.btn_nk_set_ofis);
            this.gp_tt_type.Items.Add(this.btn_nk_set_detmag);
            this.gp_tt_type.Items.Add(this.btn_nk_set_apteka);
            this.gp_tt_type.Items.Add(this.btn_nk_set_discounter);
            this.gp_tt_type.Items.Add(this.btn_nk_set_inet);
            this.gp_tt_type.Items.Add(this.btn_nk_set_stroy);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_pril_spec);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_pril_prod);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_kont_spec);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_pril_hozt);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_pavilion);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_sam_mal);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_apteka);
            this.gp_tt_type.Items.Add(this.btn_nk_rozn_sam_bol);
            this.gp_tt_type.Items.Add(this.btn_nk_opt_kb);
            this.gp_tt_type.Items.Add(this.btn_nk_opt_cash);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_c_c);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_giperm);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_superm);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_minim);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_dragstore);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_rc);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_mag_pril);
            this.gp_tt_type.Items.Add(this.btn_kgk_set_ofis);
            this.gp_tt_type.Items.Add(this.btn_nk_nek);
            this.gp_tt_type.Items.Add(this.btn_nk_cash);
            this.gp_tt_type.Items.Add(this.btn_kgk_cash);
            this.gp_tt_type.Items.Add(this.btn_kgk_nek);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_rest);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_ot);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_kafe_bar);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_t_bistro_pit);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_obshepit);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_proizv);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_bar);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_kafe);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_stol);
            this.gp_tt_type.Items.Add(this.btn_kgk_hor_p_bistro_obs);
            this.gp_tt_type.Items.Add(this.btn_kgk_opt_kb);
            this.gp_tt_type.Items.Add(this.btn_kgk_opt_cash);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_minimar);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_apteka);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_superm);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_dragstore);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_prilavok);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_t_rynok);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_hozmag);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_nek);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_cash);
            this.gp_tt_type.Items.Add(this.btn_kgk_rozn_pav);
            this.gp_tt_type.Label = "Тип магазина";
            this.gp_tt_type.Name = "gp_tt_type";
            // 
            // btn_nk_set_dragstore
            // 
            this.btn_nk_set_dragstore.Label = "Драгстор";
            this.btn_nk_set_dragstore.Name = "btn_nk_set_dragstore";
            this.btn_nk_set_dragstore.Tag = "35";
            this.btn_nk_set_dragstore.Visible = false;
            this.btn_nk_set_dragstore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_dragstore_Click);
            // 
            // btn_nk_set_rc
            // 
            this.btn_nk_set_rc.Label = "РЦ";
            this.btn_nk_set_rc.Name = "btn_nk_set_rc";
            this.btn_nk_set_rc.Visible = false;
            this.btn_nk_set_rc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_rc_Click);
            // 
            // btn_nk_set_mag_pril
            // 
            this.btn_nk_set_mag_pril.Label = "Магазин с торговлей через прилавок";
            this.btn_nk_set_mag_pril.Name = "btn_nk_set_mag_pril";
            this.btn_nk_set_mag_pril.Visible = false;
            this.btn_nk_set_mag_pril.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_mag_pril_Click);
            // 
            // btn_nk_set_c_c
            // 
            this.btn_nk_set_c_c.Label = "C&&C ";
            this.btn_nk_set_c_c.Name = "btn_nk_set_c_c";
            this.btn_nk_set_c_c.Visible = false;
            this.btn_nk_set_c_c.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_c_c_Click);
            // 
            // btn_nk_set_giperm
            // 
            this.btn_nk_set_giperm.Label = "Гипермаркет";
            this.btn_nk_set_giperm.Name = "btn_nk_set_giperm";
            this.btn_nk_set_giperm.Visible = false;
            this.btn_nk_set_giperm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_giperm_Click);
            // 
            // btn_nk_set_superm
            // 
            this.btn_nk_set_superm.Label = "Супермаркет";
            this.btn_nk_set_superm.Name = "btn_nk_set_superm";
            this.btn_nk_set_superm.Visible = false;
            this.btn_nk_set_superm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_superm_Click);
            // 
            // btn_nk_set_minim
            // 
            this.btn_nk_set_minim.Label = "Минимаркет";
            this.btn_nk_set_minim.Name = "btn_nk_set_minim";
            this.btn_nk_set_minim.Visible = false;
            this.btn_nk_set_minim.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_minim_Click);
            // 
            // btn_nk_set_ofis
            // 
            this.btn_nk_set_ofis.Label = "Офис сети";
            this.btn_nk_set_ofis.Name = "btn_nk_set_ofis";
            this.btn_nk_set_ofis.Visible = false;
            this.btn_nk_set_ofis.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_ofis_Click);
            // 
            // btn_nk_set_detmag
            // 
            this.btn_nk_set_detmag.Label = "Детский Магазин";
            this.btn_nk_set_detmag.Name = "btn_nk_set_detmag";
            this.btn_nk_set_detmag.Visible = false;
            this.btn_nk_set_detmag.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_detmag_Click);
            // 
            // btn_nk_set_apteka
            // 
            this.btn_nk_set_apteka.Label = "Аптека";
            this.btn_nk_set_apteka.Name = "btn_nk_set_apteka";
            this.btn_nk_set_apteka.Visible = false;
            this.btn_nk_set_apteka.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_apteka_Click);
            // 
            // btn_nk_set_discounter
            // 
            this.btn_nk_set_discounter.Label = "Дискаунтер";
            this.btn_nk_set_discounter.Name = "btn_nk_set_discounter";
            this.btn_nk_set_discounter.Visible = false;
            this.btn_nk_set_discounter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_discounter_Click);
            // 
            // btn_nk_set_inet
            // 
            this.btn_nk_set_inet.Label = "Интернет-магазин";
            this.btn_nk_set_inet.Name = "btn_nk_set_inet";
            this.btn_nk_set_inet.Visible = false;
            this.btn_nk_set_inet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_inet_Click);
            // 
            // btn_nk_set_stroy
            // 
            this.btn_nk_set_stroy.Label = "Строительный магазин";
            this.btn_nk_set_stroy.Name = "btn_nk_set_stroy";
            this.btn_nk_set_stroy.Visible = false;
            this.btn_nk_set_stroy.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_set_stroy_Click);
            // 
            // btn_nk_rozn_pril_spec
            // 
            this.btn_nk_rozn_pril_spec.Label = "Прилавок  - специализированный";
            this.btn_nk_rozn_pril_spec.Name = "btn_nk_rozn_pril_spec";
            this.btn_nk_rozn_pril_spec.Visible = false;
            this.btn_nk_rozn_pril_spec.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_pril_spec_Click);
            // 
            // btn_nk_rozn_pril_prod
            // 
            this.btn_nk_rozn_pril_prod.Label = "Прилавок – продуктовый";
            this.btn_nk_rozn_pril_prod.Name = "btn_nk_rozn_pril_prod";
            this.btn_nk_rozn_pril_prod.Visible = false;
            this.btn_nk_rozn_pril_prod.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_pril_prod_Click);
            // 
            // btn_nk_rozn_kont_spec
            // 
            this.btn_nk_rozn_kont_spec.Label = "Контейнер на рынке – специализированный";
            this.btn_nk_rozn_kont_spec.Name = "btn_nk_rozn_kont_spec";
            this.btn_nk_rozn_kont_spec.Visible = false;
            this.btn_nk_rozn_kont_spec.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_kont_spec_Click);
            // 
            // btn_nk_rozn_pril_hozt
            // 
            this.btn_nk_rozn_pril_hozt.Label = "Прилавок – Хозтовары";
            this.btn_nk_rozn_pril_hozt.Name = "btn_nk_rozn_pril_hozt";
            this.btn_nk_rozn_pril_hozt.Visible = false;
            this.btn_nk_rozn_pril_hozt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_pril_hozt_Click);
            // 
            // btn_nk_rozn_pavilion
            // 
            this.btn_nk_rozn_pavilion.Label = "Киоск, павильон";
            this.btn_nk_rozn_pavilion.Name = "btn_nk_rozn_pavilion";
            this.btn_nk_rozn_pavilion.Visible = false;
            this.btn_nk_rozn_pavilion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_pavilion_Click);
            // 
            // btn_nk_rozn_sam_mal
            // 
            this.btn_nk_rozn_sam_mal.Label = "Магазин самообсл. – с малой полкой бытовой химии";
            this.btn_nk_rozn_sam_mal.Name = "btn_nk_rozn_sam_mal";
            this.btn_nk_rozn_sam_mal.Visible = false;
            this.btn_nk_rozn_sam_mal.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_sam_mal_Click);
            // 
            // btn_nk_rozn_apteka
            // 
            this.btn_nk_rozn_apteka.Label = "Аптека";
            this.btn_nk_rozn_apteka.Name = "btn_nk_rozn_apteka";
            this.btn_nk_rozn_apteka.Visible = false;
            this.btn_nk_rozn_apteka.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_apteka_Click);
            // 
            // btn_nk_rozn_sam_bol
            // 
            this.btn_nk_rozn_sam_bol.Label = "Магазин самообсл. – с большой полкой бытовой химии";
            this.btn_nk_rozn_sam_bol.Name = "btn_nk_rozn_sam_bol";
            this.btn_nk_rozn_sam_bol.Visible = false;
            this.btn_nk_rozn_sam_bol.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_rozn_sam_bol_Click);
            // 
            // btn_nk_opt_kb
            // 
            this.btn_nk_opt_kb.Label = "Опт (КБ)";
            this.btn_nk_opt_kb.Name = "btn_nk_opt_kb";
            this.btn_nk_opt_kb.Visible = false;
            this.btn_nk_opt_kb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_opt_kb_Click);
            // 
            // btn_nk_opt_cash
            // 
            this.btn_nk_opt_cash.Label = "Опт (КЭШ)";
            this.btn_nk_opt_cash.Name = "btn_nk_opt_cash";
            this.btn_nk_opt_cash.Visible = false;
            this.btn_nk_opt_cash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_opt_cash_Click);
            // 
            // btn_kgk_set_c_c
            // 
            this.btn_kgk_set_c_c.Label = "C&&C";
            this.btn_kgk_set_c_c.Name = "btn_kgk_set_c_c";
            this.btn_kgk_set_c_c.Visible = false;
            this.btn_kgk_set_c_c.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_c_c_Click);
            // 
            // btn_kgk_set_giperm
            // 
            this.btn_kgk_set_giperm.Label = "Гипермаркет";
            this.btn_kgk_set_giperm.Name = "btn_kgk_set_giperm";
            this.btn_kgk_set_giperm.Visible = false;
            this.btn_kgk_set_giperm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_giperm_Click);
            // 
            // btn_kgk_set_superm
            // 
            this.btn_kgk_set_superm.Label = "Супермаркет";
            this.btn_kgk_set_superm.Name = "btn_kgk_set_superm";
            this.btn_kgk_set_superm.Visible = false;
            this.btn_kgk_set_superm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_superm_Click);
            // 
            // btn_kgk_set_minim
            // 
            this.btn_kgk_set_minim.Label = "Минимаркет";
            this.btn_kgk_set_minim.Name = "btn_kgk_set_minim";
            this.btn_kgk_set_minim.Visible = false;
            this.btn_kgk_set_minim.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_minim_Click);
            // 
            // btn_kgk_set_dragstore
            // 
            this.btn_kgk_set_dragstore.Label = "Драгстор";
            this.btn_kgk_set_dragstore.Name = "btn_kgk_set_dragstore";
            this.btn_kgk_set_dragstore.Visible = false;
            this.btn_kgk_set_dragstore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_dragstore_Click);
            // 
            // btn_kgk_set_rc
            // 
            this.btn_kgk_set_rc.Label = "РЦ";
            this.btn_kgk_set_rc.Name = "btn_kgk_set_rc";
            this.btn_kgk_set_rc.Visible = false;
            this.btn_kgk_set_rc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_rc_Click);
            // 
            // btn_kgk_set_mag_pril
            // 
            this.btn_kgk_set_mag_pril.Label = "Магазин с торговлей через прилавок";
            this.btn_kgk_set_mag_pril.Name = "btn_kgk_set_mag_pril";
            this.btn_kgk_set_mag_pril.Visible = false;
            this.btn_kgk_set_mag_pril.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_mag_pril_Click);
            // 
            // btn_kgk_set_ofis
            // 
            this.btn_kgk_set_ofis.Label = "Офис сети";
            this.btn_kgk_set_ofis.Name = "btn_kgk_set_ofis";
            this.btn_kgk_set_ofis.Visible = false;
            this.btn_kgk_set_ofis.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_set_ofis_Click);
            // 
            // btn_nk_nek
            // 
            this.btn_nk_nek.Label = "Некоммерческие клиенты";
            this.btn_nk_nek.Name = "btn_nk_nek";
            this.btn_nk_nek.Visible = false;
            this.btn_nk_nek.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_nek_Click);
            // 
            // btn_nk_cash
            // 
            this.btn_nk_cash.Label = "КЭШ дистрибьютора";
            this.btn_nk_cash.Name = "btn_nk_cash";
            this.btn_nk_cash.Visible = false;
            this.btn_nk_cash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_nk_cash_Click);
            // 
            // btn_kgk_cash
            // 
            this.btn_kgk_cash.Label = "КЭШ дистрибьютора";
            this.btn_kgk_cash.Name = "btn_kgk_cash";
            this.btn_kgk_cash.Visible = false;
            this.btn_kgk_cash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_cash_Click);
            // 
            // btn_kgk_nek
            // 
            this.btn_kgk_nek.Label = "Некоммерческие клиенты";
            this.btn_kgk_nek.Name = "btn_kgk_nek";
            this.btn_kgk_nek.Visible = false;
            this.btn_kgk_nek.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_nek_Click);
            // 
            // btn_kgk_hor_rest
            // 
            this.btn_kgk_hor_rest.Label = "Ресторан";
            this.btn_kgk_hor_rest.Name = "btn_kgk_hor_rest";
            this.btn_kgk_hor_rest.Visible = false;
            this.btn_kgk_hor_rest.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_rest_Click);
            // 
            // btn_kgk_hor_ot
            // 
            this.btn_kgk_hor_ot.Label = "Отель (Гостиница)";
            this.btn_kgk_hor_ot.Name = "btn_kgk_hor_ot";
            this.btn_kgk_hor_ot.Visible = false;
            this.btn_kgk_hor_ot.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_ot_Click);
            // 
            // btn_kgk_hor_kafe_bar
            // 
            this.btn_kgk_hor_kafe_bar.Label = "Кафе Бар";
            this.btn_kgk_hor_kafe_bar.Name = "btn_kgk_hor_kafe_bar";
            this.btn_kgk_hor_kafe_bar.Visible = false;
            this.btn_kgk_hor_kafe_bar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_kafe_bar_Click);
            // 
            // btn_kgk_hor_t_bistro_pit
            // 
            this.btn_kgk_hor_t_bistro_pit.Label = "Точка быстрого питания";
            this.btn_kgk_hor_t_bistro_pit.Name = "btn_kgk_hor_t_bistro_pit";
            this.btn_kgk_hor_t_bistro_pit.Visible = false;
            this.btn_kgk_hor_t_bistro_pit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_t_bistro_pit_Click);
            // 
            // btn_kgk_hor_obshepit
            // 
            this.btn_kgk_hor_obshepit.Label = "Общепит";
            this.btn_kgk_hor_obshepit.Name = "btn_kgk_hor_obshepit";
            this.btn_kgk_hor_obshepit.Visible = false;
            this.btn_kgk_hor_obshepit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_obshepit_Click);
            // 
            // btn_kgk_hor_proizv
            // 
            this.btn_kgk_hor_proizv.Label = "Производство";
            this.btn_kgk_hor_proizv.Name = "btn_kgk_hor_proizv";
            this.btn_kgk_hor_proizv.Visible = false;
            this.btn_kgk_hor_proizv.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_proizv_Click);
            // 
            // btn_kgk_hor_bar
            // 
            this.btn_kgk_hor_bar.Label = "Бар";
            this.btn_kgk_hor_bar.Name = "btn_kgk_hor_bar";
            this.btn_kgk_hor_bar.Visible = false;
            this.btn_kgk_hor_bar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_bar_Click);
            // 
            // btn_kgk_hor_kafe
            // 
            this.btn_kgk_hor_kafe.Label = "Кафе";
            this.btn_kgk_hor_kafe.Name = "btn_kgk_hor_kafe";
            this.btn_kgk_hor_kafe.Visible = false;
            this.btn_kgk_hor_kafe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_kafe_Click);
            // 
            // btn_kgk_hor_stol
            // 
            this.btn_kgk_hor_stol.Label = "Столовая/Закусочная";
            this.btn_kgk_hor_stol.Name = "btn_kgk_hor_stol";
            this.btn_kgk_hor_stol.Visible = false;
            this.btn_kgk_hor_stol.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_stol_Click);
            // 
            // btn_kgk_hor_p_bistro_obs
            // 
            this.btn_kgk_hor_p_bistro_obs.Label = "Предприятие быстрого обслуживания";
            this.btn_kgk_hor_p_bistro_obs.Name = "btn_kgk_hor_p_bistro_obs";
            this.btn_kgk_hor_p_bistro_obs.Visible = false;
            this.btn_kgk_hor_p_bistro_obs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_hor_p_bistro_obs_Click);
            // 
            // btn_kgk_opt_kb
            // 
            this.btn_kgk_opt_kb.Label = "Опт (КБ)";
            this.btn_kgk_opt_kb.Name = "btn_kgk_opt_kb";
            this.btn_kgk_opt_kb.Visible = false;
            this.btn_kgk_opt_kb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_opt_kb_Click);
            // 
            // btn_kgk_opt_cash
            // 
            this.btn_kgk_opt_cash.Label = "Опт (КЭШ)";
            this.btn_kgk_opt_cash.Name = "btn_kgk_opt_cash";
            this.btn_kgk_opt_cash.Visible = false;
            this.btn_kgk_opt_cash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_opt_cash_Click);
            // 
            // btn_kgk_rozn_minimar
            // 
            this.btn_kgk_rozn_minimar.Label = "Минимаркет";
            this.btn_kgk_rozn_minimar.Name = "btn_kgk_rozn_minimar";
            this.btn_kgk_rozn_minimar.Visible = false;
            this.btn_kgk_rozn_minimar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_minimar_Click);
            // 
            // btn_kgk_rozn_apteka
            // 
            this.btn_kgk_rozn_apteka.Label = "Аптека";
            this.btn_kgk_rozn_apteka.Name = "btn_kgk_rozn_apteka";
            this.btn_kgk_rozn_apteka.Visible = false;
            this.btn_kgk_rozn_apteka.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_apteka_Click);
            // 
            // btn_kgk_rozn_superm
            // 
            this.btn_kgk_rozn_superm.Label = "Супермаркет";
            this.btn_kgk_rozn_superm.Name = "btn_kgk_rozn_superm";
            this.btn_kgk_rozn_superm.Visible = false;
            this.btn_kgk_rozn_superm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_superm_Click);
            // 
            // btn_kgk_rozn_dragstore
            // 
            this.btn_kgk_rozn_dragstore.Label = "Драгстор";
            this.btn_kgk_rozn_dragstore.Name = "btn_kgk_rozn_dragstore";
            this.btn_kgk_rozn_dragstore.Visible = false;
            this.btn_kgk_rozn_dragstore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_dragstore_Click);
            // 
            // btn_kgk_rozn_prilavok
            // 
            this.btn_kgk_rozn_prilavok.Label = "Магазин с торговлей через прилавок";
            this.btn_kgk_rozn_prilavok.Name = "btn_kgk_rozn_prilavok";
            this.btn_kgk_rozn_prilavok.Visible = false;
            this.btn_kgk_rozn_prilavok.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_prilavok_Click);
            // 
            // btn_kgk_rozn_t_rynok
            // 
            this.btn_kgk_rozn_t_rynok.Label = "Точка на рынке";
            this.btn_kgk_rozn_t_rynok.Name = "btn_kgk_rozn_t_rynok";
            this.btn_kgk_rozn_t_rynok.Visible = false;
            this.btn_kgk_rozn_t_rynok.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_t_rynok_Click);
            // 
            // btn_kgk_rozn_hozmag
            // 
            this.btn_kgk_rozn_hozmag.Label = "Хоз. магазин";
            this.btn_kgk_rozn_hozmag.Name = "btn_kgk_rozn_hozmag";
            this.btn_kgk_rozn_hozmag.Visible = false;
            this.btn_kgk_rozn_hozmag.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_hozmag_Click);
            // 
            // btn_kgk_rozn_nek
            // 
            this.btn_kgk_rozn_nek.Label = "Некоммерческий";
            this.btn_kgk_rozn_nek.Name = "btn_kgk_rozn_nek";
            this.btn_kgk_rozn_nek.Visible = false;
            this.btn_kgk_rozn_nek.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_nek_Click);
            // 
            // btn_kgk_rozn_cash
            // 
            this.btn_kgk_rozn_cash.Label = "КЭШ дистрибьютора";
            this.btn_kgk_rozn_cash.Name = "btn_kgk_rozn_cash";
            this.btn_kgk_rozn_cash.Visible = false;
            this.btn_kgk_rozn_cash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_cash_Click);
            // 
            // btn_kgk_rozn_pav
            // 
            this.btn_kgk_rozn_pav.Label = "Киоск, павильон";
            this.btn_kgk_rozn_pav.Name = "btn_kgk_rozn_pav";
            this.btn_kgk_rozn_pav.Visible = false;
            this.btn_kgk_rozn_pav.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_kgk_rozn_pav_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.gp_category.ResumeLayout(false);
            this.gp_category.PerformLayout();
            this.gp_cat_type.ResumeLayout(false);
            this.gp_cat_type.PerformLayout();
            this.gp_tt_type.ResumeLayout(false);
            this.gp_tt_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gp_category;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_set;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_rozn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_opt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_nek;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_kash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_tt_horeca;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gp_cat_type;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox combo_zavod;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox combo_category;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gp_tt_type;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_nek;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_cash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_cash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_nek;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_rest;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_ot;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_kafe_bar;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_t_bistro_pit;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_obshepit;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_proizv;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_bar;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_kafe;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_stol;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_hor_p_bistro_obs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_opt_kb;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_opt_cash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_minimar;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_apteka;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_superm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_dragstore;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_prilavok;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_t_rynok;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_hozmag;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_nek;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_cash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_rozn_pav;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_c_c;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_giperm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_superm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_minim;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_dragstore;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_rc;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_mag_pril;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_kgk_set_ofis;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_opt_kb;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_opt_cash;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_pril_spec;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_pril_prod;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_kont_spec;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_pril_hozt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_pavilion;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_sam_mal;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_apteka;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_rozn_sam_bol;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_dragstore;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_rc;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_mag_pril;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_c_c;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_giperm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_superm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_minim;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_ofis;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_detmag;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_apteka;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_discounter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_inet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_nk_set_stroy;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}

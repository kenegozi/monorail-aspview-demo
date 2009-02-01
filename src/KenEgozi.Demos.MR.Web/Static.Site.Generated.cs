
namespace StaticSiteMap
{
	public static class Static
	{
		public static Root Site = new Root();
	}
	public partial class Root 
	{
		public readonly Root_Assets Assets = new Root_Assets();
	}

	public partial class Root_Assets 
	{
		public readonly Root_Assets_Images Images = new Root_Assets_Images();
		public readonly Root_Assets_Scripts Scripts = new Root_Assets_Scripts();
		public readonly Root_Assets_Styles Styles = new Root_Assets_Styles();
	}

	public partial class Root_Assets_Images 
	{
		public readonly string error_jpg = "/Assets/Images/error.jpg";
	}

	public partial class Root_Assets_Scripts 
	{
		public readonly string jquery_1_3_1_min_js = "/Assets/Scripts/jquery-1.3.1.min.js";
		public readonly string jquery_validate_min_js = "/Assets/Scripts/jquery.validate.min.js";
		public readonly string prototype_1_6_0_2_js = "/Assets/Scripts/prototype-1.6.0.2.js";
		public readonly string validation_js = "/Assets/Scripts/validation.js";
		public readonly Root_Assets_Scripts_ingrid ingrid = new Root_Assets_Scripts_ingrid();
		public readonly Root_Assets_Scripts_jqGrid jqGrid = new Root_Assets_Scripts_jqGrid();
	}

	public partial class Root_Assets_Scripts_ingrid 
	{
		public readonly string jquery_ingrid_0_9_2_js = "/Assets/Scripts/ingrid/jquery.ingrid-0.9.2.js";
		public readonly string ingrid_css = "/Assets/Scripts/ingrid/ingrid.css";
		public readonly Root_Assets_Scripts_ingrid_images images = new Root_Assets_Scripts_ingrid_images();
	}

	public partial class Root_Assets_Scripts_ingrid_images 
	{
		public readonly string grid_hrow_gif = "/Assets/Scripts/ingrid/images/grid-hrow.gif";
		public readonly string grid_loading_done_gif = "/Assets/Scripts/ingrid/images/grid-loading-done.gif";
		public readonly string grid_loading_gif = "/Assets/Scripts/ingrid/images/grid-loading.gif";
		public readonly string grid_split_gif = "/Assets/Scripts/ingrid/images/grid-split.gif";
		public readonly string indicator_web20_working_gif = "/Assets/Scripts/ingrid/images/indicator_web20_working.gif";
		public readonly string page_bg_gif = "/Assets/Scripts/ingrid/images/page-bg.gif";
		public readonly string arrow_down_png = "/Assets/Scripts/ingrid/images/arrow_down.png";
		public readonly string arrow_up_png = "/Assets/Scripts/ingrid/images/arrow_up.png";
		public readonly string load_bg_png = "/Assets/Scripts/ingrid/images/load-bg.png";
		public readonly string page_first_off_png = "/Assets/Scripts/ingrid/images/page-first-off.png";
		public readonly string page_first_png = "/Assets/Scripts/ingrid/images/page-first.png";
		public readonly string page_last_off_png = "/Assets/Scripts/ingrid/images/page-last-off.png";
		public readonly string page_last_png = "/Assets/Scripts/ingrid/images/page-last.png";
		public readonly string page_next_off_png = "/Assets/Scripts/ingrid/images/page-next-off.png";
		public readonly string page_next_png = "/Assets/Scripts/ingrid/images/page-next.png";
		public readonly string page_prev_off_png = "/Assets/Scripts/ingrid/images/page-prev-off.png";
		public readonly string page_prev_png = "/Assets/Scripts/ingrid/images/page-prev.png";
		public readonly string sort_asc_png = "/Assets/Scripts/ingrid/images/sort-asc.png";
		public readonly string sort_desc_png = "/Assets/Scripts/ingrid/images/sort-desc.png";
		public readonly string sort_none_png = "/Assets/Scripts/ingrid/images/sort-none.png";
	}

	public partial class Root_Assets_Scripts_jqGrid 
	{
		public readonly string jquery_jqGrid_js = "/Assets/Scripts/jqGrid/jquery.jqgrid.js";
		public readonly Root_Assets_Scripts_jqGrid_js js = new Root_Assets_Scripts_jqGrid_js();
		public readonly Root_Assets_Scripts_jqGrid_themes themes = new Root_Assets_Scripts_jqGrid_themes();
	}

	public partial class Root_Assets_Scripts_jqGrid_js 
	{
		public readonly string grid_base_js = "/Assets/Scripts/jqGrid/js/grid.base.js";
		public readonly string grid_celledit_js = "/Assets/Scripts/jqGrid/js/grid.celledit.js";
		public readonly string grid_common_js = "/Assets/Scripts/jqGrid/js/grid.common.js";
		public readonly string grid_custom_js = "/Assets/Scripts/jqGrid/js/grid.custom.js";
		public readonly string grid_formedit_js = "/Assets/Scripts/jqGrid/js/grid.formedit.js";
		public readonly string grid_import_js = "/Assets/Scripts/jqGrid/js/grid.import.js";
		public readonly string grid_inlinedit_js = "/Assets/Scripts/jqGrid/js/grid.inlinedit.js";
		public readonly string grid_locale_bg_js = "/Assets/Scripts/jqGrid/js/grid.locale-bg.js";
		public readonly string grid_locale_de_js = "/Assets/Scripts/jqGrid/js/grid.locale-de.js";
		public readonly string grid_locale_en_js = "/Assets/Scripts/jqGrid/js/grid.locale-en.js";
		public readonly string grid_locale_fr_js = "/Assets/Scripts/jqGrid/js/grid.locale-fr.js";
		public readonly string grid_locale_is_js = "/Assets/Scripts/jqGrid/js/grid.locale-is.js";
		public readonly string grid_locale_it_js = "/Assets/Scripts/jqGrid/js/grid.locale-it.js";
		public readonly string grid_locale_pl_js = "/Assets/Scripts/jqGrid/js/grid.locale-pl.js";
		public readonly string grid_locale_pt_br_js = "/Assets/Scripts/jqGrid/js/grid.locale-pt-br.js";
		public readonly string grid_locale_pt_js = "/Assets/Scripts/jqGrid/js/grid.locale-pt.js";
		public readonly string grid_locale_ru_js = "/Assets/Scripts/jqGrid/js/grid.locale-ru.js";
		public readonly string grid_locale_sp_js = "/Assets/Scripts/jqGrid/js/grid.locale-sp.js";
		public readonly string grid_locale_tr_js = "/Assets/Scripts/jqGrid/js/grid.locale-tr.js";
		public readonly string grid_postext_js = "/Assets/Scripts/jqGrid/js/grid.postext.js";
		public readonly string grid_setcolumns_js = "/Assets/Scripts/jqGrid/js/grid.setcolumns.js";
		public readonly string grid_subgrid_js = "/Assets/Scripts/jqGrid/js/grid.subgrid.js";
		public readonly string grid_tbltogrid_js = "/Assets/Scripts/jqGrid/js/grid.tbltogrid.js";
		public readonly string grid_treegrid_js = "/Assets/Scripts/jqGrid/js/grid.treegrid.js";
		public readonly string jqDnR_js = "/Assets/Scripts/jqGrid/js/jqdnr.js";
		public readonly string jqModal_js = "/Assets/Scripts/jqGrid/js/jqmodal.js";
		public readonly string jquery_fmatter_js = "/Assets/Scripts/jqGrid/js/jquery.fmatter.js";
		public readonly string jquery_tablednd_js = "/Assets/Scripts/jqGrid/js/jquery.tablednd.js";
		public readonly string json2_js = "/Assets/Scripts/jqGrid/js/json2.js";
		public readonly string JsonXml_js = "/Assets/Scripts/jqGrid/js/jsonxml.js";
	}

	public partial class Root_Assets_Scripts_jqGrid_themes 
	{
		public readonly Root_Assets_Scripts_jqGrid_themes_steel steel = new Root_Assets_Scripts_jqGrid_themes_steel();
	}

	public partial class Root_Assets_Scripts_jqGrid_themes_steel 
	{
		public readonly string grid_css = "/Assets/Scripts/jqGrid/themes/steel/grid.css";
		public readonly Root_Assets_Scripts_jqGrid_themes_steel_images images = new Root_Assets_Scripts_jqGrid_themes_steel_images();
	}

	public partial class Root_Assets_Scripts_jqGrid_themes_steel_images 
	{
		public readonly string bg_gif = "/Assets/Scripts/jqGrid/themes/steel/images/bg.gif";
		public readonly string cd_run_gif = "/Assets/Scripts/jqGrid/themes/steel/images/cd_run.gif";
		public readonly string dirty_gif = "/Assets/Scripts/jqGrid/themes/steel/images/dirty.gif";
		public readonly string down_gif = "/Assets/Scripts/jqGrid/themes/steel/images/down.gif";
		public readonly string fhbg_gif = "/Assets/Scripts/jqGrid/themes/steel/images/fhbg.gif";
		public readonly string find_gif = "/Assets/Scripts/jqGrid/themes/steel/images/find.gif";
		public readonly string find1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/find1.gif";
		public readonly string first_gif = "/Assets/Scripts/jqGrid/themes/steel/images/first.gif";
		public readonly string headerleft1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/headerleft1.gif";
		public readonly string headerright1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/headerright1.gif";
		public readonly string ico_close_gif = "/Assets/Scripts/jqGrid/themes/steel/images/ico-close.gif";
		public readonly string last_gif = "/Assets/Scripts/jqGrid/themes/steel/images/last.gif";
		public readonly string line3_gif = "/Assets/Scripts/jqGrid/themes/steel/images/line3.gif";
		public readonly string minus_gif = "/Assets/Scripts/jqGrid/themes/steel/images/minus.gif";
		public readonly string next_gif = "/Assets/Scripts/jqGrid/themes/steel/images/next.gif";
		public readonly string nochild_gif = "/Assets/Scripts/jqGrid/themes/steel/images/nochild.gif";
		public readonly string odown_gif = "/Assets/Scripts/jqGrid/themes/steel/images/odown.gif";
		public readonly string off_first_gif = "/Assets/Scripts/jqGrid/themes/steel/images/off-first.gif";
		public readonly string off_last_gif = "/Assets/Scripts/jqGrid/themes/steel/images/off-last.gif";
		public readonly string off_next_gif = "/Assets/Scripts/jqGrid/themes/steel/images/off-next.gif";
		public readonly string off_prev_gif = "/Assets/Scripts/jqGrid/themes/steel/images/off-prev.gif";
		public readonly string oup_gif = "/Assets/Scripts/jqGrid/themes/steel/images/oup.gif";
		public readonly string plus_gif = "/Assets/Scripts/jqGrid/themes/steel/images/plus.gif";
		public readonly string prev_gif = "/Assets/Scripts/jqGrid/themes/steel/images/prev.gif";
		public readonly string refresh_gif = "/Assets/Scripts/jqGrid/themes/steel/images/refresh.gif";
		public readonly string refresh1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/refresh1.gif";
		public readonly string resize_gif = "/Assets/Scripts/jqGrid/themes/steel/images/resize.gif";
		public readonly string row_add_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_add.gif";
		public readonly string row_add1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_add1.gif";
		public readonly string row_delete_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_delete.gif";
		public readonly string row_delete1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_delete1.gif";
		public readonly string row_edit_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_edit.gif";
		public readonly string row_edit1_gif = "/Assets/Scripts/jqGrid/themes/steel/images/row_edit1.gif";
		public readonly string sort_asc_gif = "/Assets/Scripts/jqGrid/themes/steel/images/sort_asc.gif";
		public readonly string sort_desc_gif = "/Assets/Scripts/jqGrid/themes/steel/images/sort_desc.gif";
		public readonly string spacer_gif = "/Assets/Scripts/jqGrid/themes/steel/images/spacer.gif";
		public readonly string tab_close_on_gif = "/Assets/Scripts/jqGrid/themes/steel/images/tab_close-on.gif";
		public readonly string tree_leaf_gif = "/Assets/Scripts/jqGrid/themes/steel/images/tree_leaf.gif";
		public readonly string tree_minus_gif = "/Assets/Scripts/jqGrid/themes/steel/images/tree_minus.gif";
		public readonly string tree_plus_gif = "/Assets/Scripts/jqGrid/themes/steel/images/tree_plus.gif";
		public readonly string up_gif = "/Assets/Scripts/jqGrid/themes/steel/images/up.gif";
		public readonly string wbg_gif = "/Assets/Scripts/jqGrid/themes/steel/images/wbg.gif";
		public readonly string Arrow2_Down_png = "/Assets/Scripts/jqGrid/themes/steel/images/arrow2 down.png";
		public readonly string Arrow2_Up_png = "/Assets/Scripts/jqGrid/themes/steel/images/arrow2 up.png";
		public readonly string control_090_png = "/Assets/Scripts/jqGrid/themes/steel/images/control_090.png";
		public readonly string control_270_png = "/Assets/Scripts/jqGrid/themes/steel/images/control_270.png";
		public readonly string first_png = "/Assets/Scripts/jqGrid/themes/steel/images/first.png";
		public readonly string folder_png = "/Assets/Scripts/jqGrid/themes/steel/images/folder.png";
		public readonly string last_png = "/Assets/Scripts/jqGrid/themes/steel/images/last.png";
		public readonly string next_png = "/Assets/Scripts/jqGrid/themes/steel/images/next.png";
		public readonly string prev_png = "/Assets/Scripts/jqGrid/themes/steel/images/prev.png";
		public readonly string sprite_png = "/Assets/Scripts/jqGrid/themes/steel/images/sprite.png";
	}

	public partial class Root_Assets_Styles 
	{
		public readonly string default_css = "/Assets/Styles/default.css";
		public readonly string pets_css = "/Assets/Styles/pets.css";
	}

}

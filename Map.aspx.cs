﻿using System;
using System.Collections.Generic;
using System.Web.UI;
using Subgurim.Controles;
//For Gmap

namespace BSIraq
{
    public partial class Map : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //مواقع البيوت على الخريطه

            //some test

            //مدينة بغداد
            var latlng = new GLatLng(33.303708016355245, 44.3720680475235);
            var latlng1 = new GLatLng(33.30494095074294, 44.3713653087616);
            var latlng2 = new GLatLng(33.306223184015565, 44.37358617782593);
            //مدينة كربلاء
            var latlng3 = new GLatLng(32.615039238431486, 44.03835028409958);
            var latlng4 = new GLatLng(32.61548656961024, 44.03770387172699);
            var latlng5 = new GLatLng(32.61622759816053, 44.037339091300964);


            GMap1.enableHookMouseWheelToZoom = true;

            GMap1.setCenter(latlng, 7, GMapType.GTypes.Hybrid);


            //اضهار صورة مقربة للموقع

            //GMarker marker = new GMarker(latlng);
            //GInfoWindowOptions IWoptions = new GInfoWindowOptions(17, GMapType.GTypes.Hybrid);
            //GShowMapBlowUp mbUp = new GShowMapBlowUp(marker, false, IWoptions);
            //gMap.addShowMapBlowUp(mbUp);


            var iwTabs = new GInfoWindowTabs();

            var icono1 = new GMarker(latlng);
            iwTabs.gMarker = icono1;
            iwTabs.point = latlng;

            var tabs = new List<GInfoWindowTab>();

            tabs.Add(new GInfoWindowTab("معلومات عامه ", "نكتب بعض المعلومات"));
            tabs.Add(new GInfoWindowTab("صور ", "نضغ بعض الصور"));
            tabs.Add(new GInfoWindowTab("الإتصال ", "<div class='info'  >الإتصال بالمكتب العقاري</div>"));


            iwTabs.tabs = tabs;
            GMap1.addInfoWindowTabs(iwTabs);


            var icono2 = new GMarker(latlng3);
            var window2 = new GInfoWindow(icono2, "عماره <b>عماره سلام ان شاء الله</b>", false, GListener.Event.click);
            GMap1.addInfoWindow(window2);


            var iwTabs2 = new GInfoWindowTabs();

            var icono = new GMarker(latlng5);

            iwTabs2.gMarker = icono;
            iwTabs2.tabs = tabs;
            GMap1.addInfoWindowTabs(iwTabs2);
        }
    }
}
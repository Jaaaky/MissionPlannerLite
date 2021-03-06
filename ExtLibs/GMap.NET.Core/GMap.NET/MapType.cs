﻿
namespace GMap.NET
{
   using System;

   /// <summary>
   /// types of great maps, legacy, not used anymore,
   /// left for old ids                                          
   /// </summary>
   public enum MapType
   {
      None = 0, // displays no map

      OpenStreetMap = 32, //
      OpenStreetOsm = 33, //
      OpenStreetMapSurfer = 34, //
      OpenStreetMapSurferTerrain = 35, //
      OpenSeaMapLabels = 36, //
      OpenSeaMapHybrid = 37, //
      OpenCycleMap = 38,  //

      YahooMap = 64,
      YahooSatellite = 128,
      YahooLabels = 256,
      YahooHybrid = 333,

      BingMap = 444,
      BingMap_New = 455,
      BingSatellite = 555,
      BingHybrid = 666,

      ArcGIS_StreetMap_World_2D = 777,
      ArcGIS_Imagery_World_2D = 788,
      ArcGIS_ShadedRelief_World_2D = 799,
      ArcGIS_Topo_US_2D = 811,

      #region -- use these numbers to clean up old stuff --
      //ArcGIS_MapsLT_Map_Old= 877,
      //ArcGIS_MapsLT_OrtoFoto_Old = 888,
      //ArcGIS_MapsLT_Map_Labels_Old = 890,
      //ArcGIS_MapsLT_Map_Hybrid_Old = 899, 
      //ArcGIS_MapsLT_Map=977,
      //ArcGIS_MapsLT_OrtoFoto=988,
      //ArcGIS_MapsLT_Map_Labels=990,
      //ArcGIS_MapsLT_Map_Hybrid=999,
      //ArcGIS_MapsLT_Map=978,
      //ArcGIS_MapsLT_OrtoFoto=989,
      //ArcGIS_MapsLT_Map_Labels=991,
      //ArcGIS_MapsLT_Map_Hybrid=998, 
      #endregion

      ArcGIS_World_Physical_Map = 822,
      ArcGIS_World_Shaded_Relief = 833,
      ArcGIS_World_Street_Map = 844,
      ArcGIS_World_Terrain_Base = 855,
      ArcGIS_World_Topo_Map = 866,

      MapsLT_Map = 1000,
      MapsLT_OrtoFoto = 1001,
      MapsLT_Map_Labels = 1002,
      MapsLT_Map_Hybrid = 1003,
      MapsLT_Map_2_5D = 1004,       // 2.5D only for zoom 10 & 11
      MapsLT_OrtoFoto_2010 = 1101,  // new but only partial coverage
      MapsLT_Map_Hybrid_2010 = 1103, // --..--

      KarteLV_Map = 1500,

      PergoTurkeyMap = 2001,
      SigPacSpainMap = 3001,

      YandexMapRu = 5000,
      YandexMapRuSatellite = 5001,
      YandexMapRuLabels = 5002,
      YandexMapRuHybrid = 5003,

      MapBenderWMS = 6000,

      NearMap = 8000,
      NearMapSatellite = 8001,
      NearMapLabels = 8002,
      NearMapHybrid = 8003,

      OviMap = 9000,
      OviMapSatellite = 9001,
      OviMapHybrid = 9002,
      OviMapTerrain = 9003,
   }
}

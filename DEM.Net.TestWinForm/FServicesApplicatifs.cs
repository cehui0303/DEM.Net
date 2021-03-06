﻿using DEM.Net.Core.Services.Lab;
using DEM.Net.Core.Services.VisualisationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.Net.TestWinForm
{
    public class FServicesApplicatifs
    {
        public static IServicesApplicatifs createEchantillonsTestsServices()
        {
            return new EchantillonsTestsServices();
        }
        public static IStatsPopulationServices createStatsPopServices()
        {
            return new StatsPopulationServices();
        }
        public static IVisualisationSpatialTraceServices createVisuSpatialTrace()
        {
            return new VisualisationSpatialTraceServices();
        }
        public static ITestsUnitairesLab createTestsUnitairesLab()
        {
            return new TestsUnitairesLab();
        }
        public static ICalculServicesMedium_testDivers createCalculServicesMedium_testDivers()
        {
            return new CalculServices_Medium();
        }
        public static ICalculServicesLow_testsDivers createCalculServicesLow_testDivers()
        {
            return new CalculServices_Low();
        }
        public static ITestsDiversServices createTestsDivers()
        {
            return new TestsDiversServices();
        }
    }
}

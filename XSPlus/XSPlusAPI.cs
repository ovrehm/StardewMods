﻿namespace XSPlus
{
    using System;
    using System.Collections.Generic;
    using Common.Integrations.XSPlus;
    using Common.Services;

    /// <inheritdoc />
    public class XSPlusAPI : IXSPlusAPI
    {
        private readonly ServiceManager _serviceManager;

        /// <summary>
        ///     Initializes a new instance of the <see cref="XSPlusAPI" /> class.
        /// </summary>
        /// <param name="mod">The mod instance.</param>
        public XSPlusAPI(XSPlus mod)
        {
            this._serviceManager = mod.ServiceManager;
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, bool param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, float param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, int param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, string param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, HashSet<string> param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, Dictionary<string, bool> param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }

        /// <inheritdoc />
        public void EnableWithModData(string featureName, string key, string value, Tuple<int, int, int> param)
        {
            this._serviceManager.EnableFeatureWithModData(featureName, key, value, param);
        }
    }
}
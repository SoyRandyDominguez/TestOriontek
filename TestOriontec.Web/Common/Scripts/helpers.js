var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('TestOriontec');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);
(function(){
    "use strict";

    const DATA_URL = "https://data.stad.gent/api/records/1.0/search/?dataset=publiek-sanitair-gent&q=";

    function getData(url, callback){
        let request = new XMLHttpRequest();
        request.open("GET", url);
        request.responseType = "json";
        request.send();

        request.addEventListener("load", function(){
            callback(request.response);
        });

        /*
        fetch(url).then(function(response){
            return response.json();
        }*/
    }

    function showFacilities(data){
        let bobTheHtmlBuilder = "";
        for(let i = 0; i < data.records.length; i++){
            let record = data.records[i];
            let fields = record.fields;
            let address = fields.adres;
            let description = fields.beschrijving;
            let facility = new Facility(address, description);
            facility.setNumberOfToilets(fields.toiletten);
            facility.setNumberOfUrinals(fields.urinoirs);
            facility.setOpenHours(fields.openingsuren);
            facility.setImage(fields.beeld);
            
            bobTheHtmlBuilder += `<div class='facilities__facility'><figure><img src='${facility.getImage()}' /><figcaption>${facility.address}</figcaption></figure></div>`;

        }

        document.getElementById("facilities").innerHTML = bobTheHtmlBuilder;
    }

    getData(DATA_URL, showFacilities);



})();
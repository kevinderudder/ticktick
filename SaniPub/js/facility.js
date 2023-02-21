function Facility(address, description){
    this.address = address;
    this.description = description;
    this.numberOfToilets = 0;
    this.numberOfUrinals = 0;
    this.openHours = "";
    this.image = "";

    this.setNumberOfToilets = function(numberOfToilets){
        this.numberOfToilets = numberOfToilets;
    }

    this.getNumberOfToilets = function(){
        return this.numberOfToilets;
    }

    this.setNumberOfUrinals = function(numberOfUrinals){
        this.numberOfUrinals = numberOfUrinals;
    }

    this.getNumberOfUrinals = function(){
        return this.numberOfUrinals;
    }

    this.setOpenHours = function(openHours){
        this.openHours = openHours;
    }

    this.getOpenHours = function(){
        return this.openHours;
    }

    this.setImage = function(image){    
        this.image = image;
    }

    this.getImage = function(){
        if(this.image) return this.image
        else return "https://crewcare.co.nz/admin_assets/blog/public-toilets.jpg"
    }

}
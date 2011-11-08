DeployBoard.FormValidator = function (myProperty, form) {
    this.myProperty = myProperty;
    this.form = form;

    console.log(this);
    
    this.form.submit(this.validate);
};
DeployBoard.FormValidator.prototype.validate = function () {
    console.log(form(Element(this)));
    
};

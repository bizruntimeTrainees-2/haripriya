var Customer = /** @class */ (function () {
    function Customer() {
        this.CustomerName = ""; //CustomerName-entity
    }
    Customer.prototype.validate = function (input) {
        alert("test");
        return true; //data type
    };
    return Customer;
}());
/*
 *
 * INHERITANCE:
class SomeOtherCustomer extends Customer {
    Validate() {
        alert("this is alert");
    }
}*/
/*
 * Exception:
    if(value.length==0){
    throw new evalError;
    throw "Customer Name is required";
}

/*
 *
 * SET and GET:
  private CustomerName:string="";
  public set CustomerName(value:string){
  this.CustomerName;
  }
  public get CustomerName():string{
  return this.CustomerName;
  }*/
//all js code-ts file
//var test="sss";//perfect ts code
//# sourceMappingURL=file1.js.map
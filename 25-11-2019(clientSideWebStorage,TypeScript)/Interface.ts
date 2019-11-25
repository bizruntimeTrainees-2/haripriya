interface KeyPair {
    key: number;
    value: string;
}
let kv1: KeyPair ={ key:1, value:"Steve" }; 
//let kv2: KeyPair ={ key:1, val:"Steve" }; 
//let kv3: KeyPair ={ key:1, value:100 }; 

//function type
interface KeyValueProcessor {
    (key: number, value: string): void;
};

function addKeyValue(key: number, value: string): void {
    console.log('addKeyValue: key = ' + key + ', value = ' + value)
}

function updateKeyValue(key: number, value: string): void {
    console.log('updateKeyValue: key = ' + key + ', value = ' + value)
}

let kvp: KeyValueProcessor = addKeyValue;
kvp(1, 'Bill'); 

kvp = updateKeyValue;
kvp(2, 'Steve');  



interface NumList {
    [index: number]: number
}
let numArr: NumList = [1, 2, 3];
numArr[0];
numArr[1];
interface IStringList {
    [index: string]: string
}
let strArr: IStringList;
strArr["TS"] = "TypeScript";
strArr["JS"] = "JavaScript";
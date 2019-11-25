var kv1 = { key: 1, value: "Steve" };
;
function addKeyValue(key, value) {
    console.log('addKeyValue: key = ' + key + ', value = ' + value);
}
function updateKeyValue(key, value) {
    console.log('updateKeyValue: key = ' + key + ', value = ' + value);
}
var kvp = addKeyValue;
kvp(1, 'Bill');
kvp = updateKeyValue;
kvp(2, 'Steve');
var numArr = [1, 2, 3];
numArr[0];
numArr[1];
var strArr;
strArr["TS"] = "TypeScript";
strArr["JS"] = "JavaScript";
//# sourceMappingURL=Interface.js.map
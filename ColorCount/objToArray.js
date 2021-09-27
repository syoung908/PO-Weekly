var obj = {
	a : "thing1",
  b : "thing2"
}

var objToArray = (o) => {
	var arr = [];
	for (const prop in o) {
  	arr.push(o[prop])
  }
  return arr;
}

console.log(objToArray(obj));
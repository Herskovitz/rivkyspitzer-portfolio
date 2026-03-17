
const myHeaders = new Headers();
myHeaders.append("apikey", "6usCioKbpzotdjFtDQcp7PDMW2BVL6Jt");

const requestOptions = {
    method: 'GET',
    redirect: 'follow',
    headers: myHeaders
};

let c1 = await convertIngredient("Liter", "Gallon", 2, "Milk");
if (c1) {
    console.log(c1.answer);
} else {
    console.error("Conversion failed or no response");
}

let c2 = await convertIngredient("Tablespoon", "Cup", 1, "Sugar");
if (c2) {
    console.log(c2.answer);
} else {
    console.error("Conversion failed or no response");
}

async function convertIngredient(targetUnit, sourceUnit, sourceAmount, ingredientName) {

    try {
        let sp = new URLSearchParams();

        sp.append("targetUnit", targetUnit);
        sp.append("sourceUnit", sourceUnit);
        sp.append("sourceAmount", sourceAmount);
        sp.append("ingredientName", ingredientName);

        let url = "https://api.apilayer.com/spoonacular/recipes/convert?" + sp.toString();

        let response = await fetch(url, requestOptions);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        let conversion = await response.json();

        return conversion;
    }
    catch (e) {
        console.log(e.message);
    }
}






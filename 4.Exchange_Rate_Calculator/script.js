const currencyEl_one = document.getElementById('currency-one');
const currencyEl_two = document.getElementById('currency-two');

const ammountEl_one = document.getElementById('amount-one');
const ammountEl_two = document.getElementById('amount-two');

const rateEl = document.getElementById('rate');

const swap = document.getElementById('swap');

// Fetch exchange rates and update the DOM
function calculate() {
    const currency_one = currencyEl_one.value;
    const currency_two = currencyEl_two.value;

    fetch(`https://v6.exchangerate-api.com/v6/978604d5e1c5f22510d2a72d/latest/${currency_one}`)
        .then(res => res.json())
        .then(data => {
            // console.log(data);
            const rate = data.conversion_rates[currency_two];
            rateEl.innerText = `1 ${currency_one} = ${rate} ${currency_two}`;
            ammountEl_two.value = (ammountEl_one.value * rate).toFixed(2);
        })
}

// Event Listeners
currencyEl_one.addEventListener('change', calculate);
ammountEl_one.addEventListener('input', calculate);

currencyEl_two.addEventListener('change', calculate);
ammountEl_two.addEventListener('input', calculate);

swap.addEventListener('click', () => {
    const temp = currencyEl_one.value;
    currencyEl_one.value = currencyEl_two.value;
    currencyEl_two.value = temp;
    calculate();
});

calculate();
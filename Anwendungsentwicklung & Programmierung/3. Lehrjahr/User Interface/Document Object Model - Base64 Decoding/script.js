function convert_atob() {
    let base64_string = prompt("Ihr Base64 String:")

    document.getElementById("enc_strg").innerHTML = "";
    document.getElementById("dec_strg").innerHTML = "";

    if(base64_string != null) {
        document.getElementById("enc_strg").innerHTML = "Encoded String: " + base64_string;

        document.getElementById("dec_strg").innerHTML = "Decoded String: " + atob(base64_string);
    }
}

function convert_btoa() {
    let string = prompt("Ihr Base64 String:")

    document.getElementById("enc_strg").innerHTML = "";
    document.getElementById("dec_strg").innerHTML = "";

    if(string != null) {
        document.getElementById("enc_strg").innerHTML = "Encoded String: " + string;

        document.getElementById("dec_strg").innerHTML = "Decoded String: " + btoa(string);
    }
}
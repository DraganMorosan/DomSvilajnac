$(function () {
    var datumRegex = /(^(((0[1-9]|1[0-9]|2[0-8])[\.](0[1-9]|1[012]))|((29|30|31)[\.](0[13578]|1[02]))|((29|30)[\.](0[4,6,9]|11)))[\.](19|[2-9][0-9])\d\d$)|(^29[\.]02[\.](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)/
    var datumRegexOptional = /(^$)|(^(((0[1-9]|1[0-9]|2[0-8])[\.](0[1-9]|1[012]))|((29|30|31)[\.](0[13578]|1[02]))|((29|30)[\.](0[4,6,9]|11)))[\.](19|[2-9][0-9])\d\d$)|(^29[\.]02[\.](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)/
    $('#ucenikForma').validate({
        rules: {
            Ime: {
                required: true,
                minlength: 2,
                maxlength: 30
            },
            Prezime: {
                required: true,
                minlength: 4,
                maxlength: 30
            },
            DatumRodjenja: {
                required: true,
                datum_regex: datumRegex
            },
            OtacObrazovanje: {
                broj: /^([1-8])?$/
            },
            MajkaObrazovanje: {
                broj: /^([1-8])?$/
            },
            DatumUseljenja: {
                required: true,
                datum_regex: datumRegex
            },
            BrojSobe: {
                broj: /^([1-2](\d?\d?\d)?)?$/
            },
            MobTelefon: {
                telefon: /(^$)|(^(06\d\d{7})?$)/
            },
            FiksniTelefon: {
                telefon: /(^$)|(^(0[1-3]\d\d{7})?$)/
            },
            DatumNapustanja: {
                required: false,
                datum_regex: datumRegexOptional
            },
            TelefonSkole: {
                telefon: /(^$)|(^(0[1-3]\d\d{7})?$)/
            }
        },
        messages: {
            Ime: {
                required: "Polje ime je obavezno.",
                minlength: "Polje ime mora sadržati najmanje 2 karaktera.",
                maxlength: "Polje ime može sadržati najviše 30 karaktera."
            },
            Prezime: {
                required: "Polje prezime je obavezno.",
                minlength: "Polje prezime mora sadržati najmanje 4 karaktera.",
                maxlength: "Polje prezime može sadržati najviše 30 karaktera."
            },
            DatumRodjenja: {
                required: "Polje datum rođenja je obavezno."
            },
            DatumUseljenja: {
                required: "Polje datum useljenja je obavezno."
            }
        },
    });
    $.validator.addMethod("datum_regex", function (value, element, regexpr) {
        return regexpr.test(value);
    }, "Unesite ispravan format datuma.");
    $.validator.addMethod("broj", function (value, element, regexpr) {
        return regexpr.test(value);
    }, "Unesite ispravan broj.");
    $.validator.addMethod("telefon", function (value, element, regexpr) {
        return regexpr.test(value);
    }, "Unesite ispravan format broja telefona.");
});
$(function () {
    
    //var datumRegex = /(^(((0[1-9]|1[0-9]|2[0-8])[\.](0[1-9]|1[012]))|((29|30|31)[\.](0[13578]|1[02]))|((29|30)[\.](0[4,6,9]|11)))[\.](19|[2-9][0-9])\d\d$)|(^29[\.]02[\.](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)/;
    var datumRegex = /^\s*(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})\s*\.$/;
    //var datumRegexOptional = /(^$)|(^(((0[1-9]|1[0-9]|2[0-8])[\.](0[1-9]|1[012]))|((29|30|31)[\.](0[13578]|1[02]))|((29|30)[\.](0[4,6,9]|11)))[\.](19|[2-9][0-9])\d\d$)|(^29[\.]02[\.](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)/;
    $('#ucenikForma').validate({
        rules: {
            Ime: {
                required: true,
            },
            Prezime: {
                required: true,
            },
            DatumRodjenja: {
                required: true,
                datum_regex: datumRegex
            },
            DatumUpisa: {
                required: true,
                datum_regex: datumRegex
            },
            NosilacStarateljstva: {
                required: true
            },
            StarateljIme: {
                required: true
            },
            StarateljPrezime: {
                required: true
            },
            NivoObrazovanja: {
                required: true,
                broj: /^([1-8])?$/
            },
            MestoRodjenja: {
                required: true
            },
            OpstinaRodjenja: {
                required: true
            },
            DrzavaRodjenja: {
                required: true
            },
            BrojUMatKnjizi: {
                number: true,
                required: true
            },
            AdresaBoravka: {
                required: true
            },
            //DatumUseljenja: {
            //    required: true,
            //    datum_regex: datumRegex
            //},
            //BrojSobe: {
            //    broj: /^([1-2](\d?\d?\d)?)?$/
            //},
            Telefon: {
                //| (^ 06\d\d{ 6-7 }$)
                telefon: /(^(0[1-3]\d\d{9})?$)|(^(06\d\d{9})?$)/
            },
            Skola: {
                required: true
            },
            ObrazovniProfil: {
                required: true
            },
            Razred: {
                required: true,
                broj: /^[1-4]$/
            }
            //TelefonSkole: {
            //    telefon: /(^$)|(^(0[1-3]\d\d{7})?$)/
            //}
        },
        messages: {
            Ime: {
                required: "Polje ime je obavezno."
                //minlength: "Polje ime mora sadržati najmanje 2 karaktera.",
                //maxlength: "Polje ime može sadržati najviše 30 karaktera."
            },
            Prezime: {
                required: "Polje prezime je obavezno.",
            },
            DatumRodjenja: {
                required: "Polje datum rođenja je obavezno."
            },
            DatumUpisa: {
                required: "Polje datum upisa je obavezno.",
            },
            NosilacStarateljstva: {
                required: "Polje nosilac starateljstva je obavezno.",
            },
            StarateljIme: {
                required: "Polje ime staratelja je obavezno.",
            },
            StarateljPrezime: {
                required: "Polje prezime staratelja je obavezno.",
            },
            NivoObrazovanja: {
                required: "Polje nivo obrazovanja je obavezno.",
            },
            MestoRodjenja: {
                required: "Polje mesto rođenja je obavezno.",
            },
            OpstinaRodjenja: {
                required: "Polje opština rođenja je obavezno.",
            },
            DrzavaRodjenja: {
                required: "Polje država rođenja je obavezno.",
            },
            BrojUMatKnjizi: {
                number: "Polje se mora sastojati od brojeva.",
                required: "Polje broj u matičnoj knjizi je obavezno.",
            },
            AdresaBoravka: {
                required: "Polje adresa boravka je obavezno.",
            },
            Telefon: {
                required: "Polje telefon je obavezno.",
            },
            Skola: {
                required: "Polje škola je obavezno.",
            },
            ObrazovniProfil: {
                required: "Polje obrazovni profil je obavezno.",
            },
            Razred: {
                required: "Polje razred je obavezno.",
            }

        }
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
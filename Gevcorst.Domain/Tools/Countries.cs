﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevcorst.Domain.Tools
{
    public class Countries
    {
        
        public static String[] countries = {" ","ALGERIA","ANGOLA","BENIN","BOTSWANA",
        "BURKINA FASO","BURUNDI","CAMEROON","CAPE VERDE",
        "CENTRAL AFRICAN REPUBLIC","CHAD","COMOROS","CONGO","DJIBOUTI","EGYPT","EQUATORIAL GUINEA","ERITREA","ETHIOPIA","GABON","THE GAMBIA","GHANA","GUINEA",
"BISSAU","COTE D’IVOIR (IVORY COAST)","KENYA","LESOTHO","LIBERIA","LIBYA","MADAGASCAR", "MALAWI",
"MALI","MAURITANIA","MAURITIUS","MOROCCO","MOZAMBIQUE","NAMIBIA","NIGER","NIGERIA","RWANDA","SAO TOME E PRINCIPE","SENEGAL","SEYCHELLES","SIERRA LEONE","SOMALIA","SOUTH AFRICA","SUDAN","SWAZILAND","TANZANIA","TOGO","TUNISIA","UGANDA","DEMOCRATIC REPUBLIC OF THE CONGO (ZAIRE)","ZAMBIA","ZIMBABWE","AFGHANISTAN","BAHRAIN","BANGLADESH","BHUTAN","BRUNEI","CAMBODIA","CHINA","CYPRUS","INDIA","INDONESIA","IRAN","IRAQ","ISRAEL","JAPAN","JORDAN","KUWAIT","LAOS","LEBANON","MALAYSIA","THE MALDIVES","MONGOLIA","MYANMAR (BURMA)","NEPAL","NORTH KOREA","OMAN","PAKISTAN","PHILIPPINES","QATAR","SAUDI ARABIA","SINGAPORE","SOUTH KOREA","SRI LANKA","SYRIA","TAIWAN (REPUBLIC OF CHINA)","THAILAND","TURKEY","UNITED ARAB EMIRATES","VIETNAM","YEMEN","AUSTRALIA","FIJI","KIRIBATI","MARSHALL ISLANDS","MICRONESIA","NAURU","NEW ZEALAND","PALAU","PAPUA NEW GUINEA","SOLOMON ISLANDS","TONGA","TUVALU","VANUATU","WESTERN SAMOA","ARMENIA",
"AZERBAIJAN","BELARUS (BYELORUSSIA)",
    "BULGARIA", "GEORGIA",
"KAZAKSTAN","KYRGYZSTAN","MOLDOVA", "RUSSIA",
"TAJIKISTAN", "TURKMENISTAN",
"UKRAINE", "UZBEKISTAN",
"ALBANIA", "ANDORRA","AUSTRIA", "BELGIUM",
"BOSNIA", "HERZEGOVINA",
"CROATIA", "CZECH REPUBLIC","DENMARK", "ESTONIA","FINLAND", "FRANCE",
"GERMANY", "GREECE","HUNGARY", "ICELAND","IRELAND", "ITALY",
"LATVIA", "LIECHTENSTEIN","LITHUANIA", "LUXEMBOURG","MACEDONIA", "MALTA",
"MONACO", "MONTENEGRO",
"THE NETHERLANDS", "NORWAY",
"POLAND", "PORTUGAL","ROMANIA","SAN MARINO","SERBIA", "SLOVAKIA","SLOVENIA","SPAIN","SWEDEN", "SWITZERLAND",
"UNITED KINGDOM","VATICAN CITY",
"ANTIGUA AND BARBUDA","BAHAMAS","BARBADOS", "BELIZE",
"CANADA", "COSTA RICA",
"CUBA","Havana",
"DOMINICAN REPUBLIC","EL SALVADOR",
"GRENADA","GUATEMALA","HAITI",
"HONDURAS", "JAMAICA","MEXICO", "NICARAGUA","PANAMA", "ST. KITTS",
"NEVIS", "ST. LUCIA","ST. VINCENT AND THE GRENADINES","UNITED STATES OF AMERICA",
"ARGENTINA","BOLIVIA","BRAZIL", "CHILE",
"COLOMBIA","ECUADOR",
"GUYANA", "PARAGUAY",
"PERU", "SURINAME",
"TRINIDAD AND TOBAGO","URUGUAY","VENEZUELA","SOUTH SUDAN"};
        public static string[]  sortAlp(String[] con)
        {
            int i, j; String temp;
            for (i = 0; i < countries.Length - 1; i++)
            {
                for (j = 0; j < countries.Length; j++)
                {
                    if (String.Compare( con[i],con[j],StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        temp = con[i];
                        con[i] = con[j];
                        con[j] = temp;
                    }

                }
            }
            return con;
        }
    }
  }


using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondChatBotDemoWithFormFlow.ChatForms
{

    [Serializable]
    public enum ReservationDays
    {
        [Describe("Cumartesi")]
        Cumartesi = 1,
        [Describe("Pazar")]
        Pazar = 2,
        [Describe("Pazartesi")]
        Pazartesi = 3
    }

    [Serializable]
    public enum ReservationSubjects
    {       
        [Describe("Motor")]
        Engine = 1,
        [Describe("Kapı")]
        Door = 2,
        [Describe("Pencere")]
        Windows = 3,
        [Describe("Emisyon")]
        Emmisson =4
    }

    [Serializable]
    public class ReservationModel
    {
        [Prompt("Adınız Soyadınız")]
        public string FullName { get; set; }
        [Prompt("Rezervasyon Gunu Hangisi Olsun? {||}")]
        public ReservationDays? Day { get; set; }
        [Prompt("Hangi konularda size yardımcı olalım? {||}")]
        public List<ReservationSubjects> Subjects { get; set; }

        public static IForm<ReservationModel> BuildForm()
        {
            return new FormBuilder<ReservationModel>()
                .Message("Rezervasyon bot ile konusmaktasınız")
                .AddRemainingFields()
                .Build();
        }

    }
}
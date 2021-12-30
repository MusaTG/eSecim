using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MayoralAdded = "Belediye Başkanı Atandı.";
        public static string MayoralTCInvalid = "Ülkenin vatandaşlığı olduğunuzdan emin olunuz.";
        public static string MayoralNone = "Atanan belediye başkanı bulunamadı.";
        public static string MayoralListed = "Adaylar listelendi.";
        public static string MayoralCountOfError = "Bu kişi zaten aday.";
        public static string VoteAdded = "Oyunuz başarıyla kullanıldı.";
        public static string MayoralInUserVote = "Oyunuzu zaten kullandınız.";
        public static string UserVoteAdded = "Oyunuz başarıyla kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string PasswordError = "Parola hatası.";
    }
}

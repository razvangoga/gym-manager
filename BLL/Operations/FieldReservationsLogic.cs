using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BLL.Nomenclators;
using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;

namespace BLL.Operations
{
    public class FieldReservationsLogic
    {
        public static void SetPriceOnFieldReservations(Field_Reservation p_field_reservation)
        {
            if (p_field_reservation == null)
                return;

            Field _field = NomenclatorsModelMethods.FieldMethods.GetFieldById(p_field_reservation.Field_id);

            if (_field == null)
                throw new Exception("Terenul selectat nu a fost gasit in baza de date!");

            if (_field.Price == 0)
                throw new Exception("Terenul selectat are pretul 0!");

            p_field_reservation.Price = _field.Price;
        }

        public static void SetDiscountOnFieldReservations(Field_Reservation p_field_reservation)
        {
            if (p_field_reservation == null)
                return;

            Client _client = NomenclatorsModelMethods.ClientMethods.GetClientById(p_field_reservation.Client_id);

            if (_client == null)
                throw new Exception("Clientul selectat nu a fost gasit in baza de date!");

            p_field_reservation.DiscountProcent = _client.DiscountProcent;
        }

        public static string GetDescriptionText(Field_Reservation p_field_reservation)
        {
            return string.Format("{0} - {1}",
                p_field_reservation.Client_id == -1
                    ? p_field_reservation.Description.Trim()
                    : NomenclatorsModelMethods.ClientMethods.GetFKValue(p_field_reservation.Client_id),
                NomenclatorsModelMethods.FieldReservationStatusesMethods.GetFKValue(p_field_reservation.Field_Reservation_Status_id));

        }

        public static byte GetHourNumberForFieldReservation(Field_Reservation p_field_reservation)
        {
            if (p_field_reservation == null)
                return 0;

            Field _field = NomenclatorsModelMethods.FieldMethods.GetFieldById(p_field_reservation.Field_id);

            if (_field == null)
                throw new Exception("Terenul selectat nu a fost gasit in baza de date!");

            return _field.MinimumRentHours;
        }

        public static FieldReservationStatus GetFieldReservationStatus(Field_Reservation p_field_reservation)
        {
            if (p_field_reservation == null)
                return FieldReservationStatus.FaraInchiriere;

            switch (p_field_reservation.Field_Reservation_Status_id)
            {
                case 1: { return FieldReservationStatus.Rezervat;}
                case 2: { return FieldReservationStatus.InCurs;}
                case 3: { return FieldReservationStatus.RezervareInchieiata; }
                default: { return FieldReservationStatus.RezervareAnulata; }
            }
        }

        public static void SetFieldandDate(Field_Reservation p_field_reservation, Field p_field, DateTime p_dateTime)
        {
            p_field_reservation.Field_id = p_field.id;
            SetPriceOnFieldReservations(p_field_reservation);
            p_field_reservation.ReservationFromDate = p_dateTime;
            p_field_reservation.ReservationToDate = p_dateTime.AddHours(p_field.MinimumRentHours);
        }

        public static void SetCancelStatus(Field_Reservation p_field_reservation)
        {
            p_field_reservation.Field_Reservation_Status_id = Convert.ToInt32(FieldReservationStatus.RezervareAnulata);
        }

        public static List<Field_Reservation> GetReservationsForHour(int p_nHour, List<Field_Reservation> p_list)
        {
            var _query = from fieldReservation in p_list
                         where fieldReservation.ReservationFromDate.Hour == p_nHour
                         orderby fieldReservation.id
                         select fieldReservation;
            return _query.ToList();
        }
    }
}

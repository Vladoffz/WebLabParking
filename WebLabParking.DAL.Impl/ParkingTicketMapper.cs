﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ParkingTicketMapper
    {
        ParkingTicketRepository parkingTicketRepository = new ParkingTicketRepository();
        public ParkingTicketDTO ParkingTicketToParkingTicketDTO(ParkingTicket parkingTicket)
        {
            ParkingTicketDTO parkingTicketDTO = new ParkingTicketDTO();
            if (parkingTicket != null)
            {
                parkingTicketDTO.LeavingTime = parkingTicket.LeavingTime;
                parkingTicketDTO.TakingTime = parkingTicket.TakingTime;
            }

            //parkingTicketDTO.ParkingPlace = new ParkingPlaceMapper().ParkingPlaceToParkingPlaceDTO(parkingTicket.ParkingPlace);
            //parkingTicketDTO.Car = new CarMapper().CarToCarDTO(parkingTicket.Car);
            //parkingTicketDTO.Client = new ClientMapper().ClientToClientDTO(parkingTicket.Client);
            return parkingTicketDTO;
        }

        public ParkingTicket ParkingTicketDTOToParkingTicket(ParkingTicketDTO parkingTicketDTO)
        {
            ////ParkingTicket parkingTicket = parkingTicketRepository.GetAll().ToList().Find(x => x.id == parkingTicketDTO.id);
            //parkingTicket.LeavingTime = parkingTicketDTO.LeavingTime;
            //parkingTicket.TakingTime = parkingTicketDTO.TakingTime;
            //parkingTicket.ParkingPlace = new ParkingPlaceMapper().ParkingPlaceDTOToParkingPlace(parkingTicketDTO.ParkingPlace);
            //parkingTicket.Car = new CarMapper().CarDTOToCar(parkingTicketDTO.Car);
            //parkingTicket.Client = new ClientMapper().ClientDTOToClient(parkingTicketDTO.Client);
            return new ParkingTicket();
        }
    }
}

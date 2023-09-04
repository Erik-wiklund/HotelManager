using System.Collections.Generic;
using System.Linq;

namespace HotelManager
{
    public class Hotel
    {
        private List<float> reviewList = new List<float>();
        private Dictionary<int, Room> hotelRooms = new Dictionary<int, Room>();
        RoomType roomValue;

        public void AddNewReview(float newReview)
        {
            reviewList.Add(newReview);
        }

        public string GetAverageReview()
        {
            float averagereview = reviewList.Average();
            return averagereview.ToString("0.00");
        }

        public int IsRoomNumberAvailable(int roomNumberInput)
        {
            int newRoomNumberInput = 0;
            foreach (var item in hotelRooms)
            {
                if (roomNumberInput == item.Value.RoomNumber)
                {
                    newRoomNumberInput = 0;
                    break;
                }
                else if (roomNumberInput != item.Value.RoomNumber)
                {
                    newRoomNumberInput = roomNumberInput;
                }
            }
            return newRoomNumberInput;
        }

        public void CreateRoom(int floorNumberInput, int roomNumerInput, int areaSizeInput)
        {
            Room room = new Room();
            room.IsRoomAvailable = true;
            if (areaSizeInput < 50)
            {
                roomValue = RoomType.Basic;
                room.NumberOfBeds = 1;
                room.NumberofBathrooms = 1;
            }

            else if (areaSizeInput >= 50 & areaSizeInput < 100)
            {
                roomValue = RoomType.Moderate;
                room.NumberOfBeds = 2;
                room.NumberofBathrooms = 1;
            }

            else if (areaSizeInput >= 100)
            {
                roomValue = RoomType.Luxury;
                room.NumberOfBeds = 2;
                room.NumberofBathrooms = 2;
            }

            room.FloorNumber = floorNumberInput;
            room.RoomNumber = roomNumerInput;
            room.AreaSize = areaSizeInput;
            room.roomType = roomValue;

            int nr = hotelRooms.Count + 1;

            hotelRooms.Add(nr, room);
        }

        public int DeleteRoom(int search)
        {   
            var roomNumber = hotelRooms.Where(room => room.Value.RoomNumber == search);

            bool empty = !roomNumber.Any();
            if (empty)
            {
                return 0;
            }

            else 
            {
                var roomNumber2 = hotelRooms.First(room => room.Value.RoomNumber == search);
                hotelRooms.Remove(roomNumber2.Key);
                return 1;
            }         
        }

        public Dictionary<int, Room> GetRooms()
        {
            return hotelRooms;
        }

        public List<Room> GetListOfAvailableRooms<IsRoomAvailable>(Dictionary<int, Room> inputDict)
        {
            return inputDict.Values.Where(Available => Available.IsRoomAvailable == true).ToList();
        }

        public List<Room> GetListOfRoomNumbers<RoomNumber>(Dictionary<int, Room> HotelRoom, int search)
        {
            return HotelRoom.Values.Where(Available => Available.RoomNumber == search).ToList();
        }

        public void CreateInitialRooms()
        {
            CreateRoom(1, 101, 30);
            CreateRoom(1, 102, 30);
            CreateRoom(1, 103, 30);
            CreateRoom(1, 104, 50);
            CreateRoom(1, 105, 50);
            CreateRoom(2, 201, 60);
            CreateRoom(2, 202, 60);
            CreateRoom(2, 203, 60);
            CreateRoom(2, 204, 100);
            CreateRoom(2, 205, 100);
        }

        public void CreateInitialReviews()
        {
            AddNewReview(1);
            AddNewReview(2);
            AddNewReview(3);
            AddNewReview(4);
            AddNewReview(5);
        }
    }
}
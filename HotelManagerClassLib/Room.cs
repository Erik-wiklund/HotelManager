namespace HotelManager
{
    public class Room
    {
        public bool IsRoomAvailable { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public int NumberofBathrooms { get; set; }
        public int AreaSize { get; set; }
        public RoomType roomType;

        public override string ToString()
        {
            string roomAvailable = "No";

            if (IsRoomAvailable == true)
            {
                roomAvailable = "Yes";
            }

            string roomInfo = "----------------------------------------------------------------------------------------------------------------------------------\n" +
            $"{roomType, -21}{roomAvailable, -21}{FloorNumber, -21}{RoomNumber, -21}{NumberOfBeds, -21}{NumberofBathrooms, -21}{AreaSize, -21}";
            return roomInfo;
        }

        public int GetRoomNumber()
        {
            return RoomNumber;
        }
    }
}
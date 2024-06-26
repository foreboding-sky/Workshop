using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace Workshop.Data
{
    public interface IWorkshopRepository
    {
        //client
        public Task<Client> CreateClient(Client client);
        public Task DeleteClient(Guid id);
        public Task<List<Client>> GetAllClients();
        public Task<Client> GetClientById(Guid id);
        public Task<Client> GetClientByModel(Client client);
        public Task<Client> UpdateClient(Client client);
        //specialist
        public Task<Specialist> CreateSpecialist(Specialist specialist);
        public Task DeleteSpecialist(Guid id);
        public Task<List<Specialist>> GetAllSpecialists();
        public Task<Specialist> GetSpecialistById(Guid id);
        public Task<Specialist> GetSpecialistByModel(Specialist specialist);
        public Task<Specialist> UpdateSpecialist(Specialist specialist);
        //repair
        public Task<Repair> CreateRepair(Repair repair);
        public Task DeleteRepair(Guid id);
        public Task<List<Repair>> GetAllRepairs();
        public Task<Repair> GetRepairById(Guid id);
        public Task<Repair> UpdateRepair(Repair repair);
        public Task<List<string>> GetAllRepairStatuses();
        //repair item
        public Task<RepairItem> CreateRepairItem(RepairItem repairItem);
        public Task<List<RepairItem>> GetAllRepairItems();
        //repair service
        public Task<RepairService> CreateRepairService(RepairService repairItem);
        public Task<List<RepairService>> GetAllRepairServices();
        //order
        public Task<Order> CreateOrder(Order order);
        public Task DeleteOrder(Guid id);
        public Task<List<Order>> GetAllOrders();
        public Task<Order> GetOrderById(Guid id);
        public Task<Order> GetOrderByModel(Order order);
        public Task<Order> UpdateOrder(Order order);
        public Task<Order> ProcessOrder(Guid id);
        //service
        public Task<Item> CreateItem(Item item);
        public Task DeleteItem(Guid id);
        public Task<List<Item>> GetAllItems();
        public Task<Item> GetItemById(Guid id);
        public Task<Item> GetItemByModel(Item item);
        public Task<List<string>> GetAllItemTypes();
        public Task<Service> UpdateService(Service service);
        //item
        public Task<Service> CreateService(Service service);
        public Task DeleteService(Guid id);
        public Task<List<Service>> GetAllServices();
        public Task<Service> GetServiceById(Guid id);
        public Task<Service> GetServiceByModel(Service service);
        //stock item
        public Task<StockItem> CreateStockItem(StockItem stockItem);
        public Task DeleteStockItem(Guid id);
        public Task<List<StockItem>> GetAllStockItems();
        public Task<StockItem> GetStockItemById(Guid id);
        public Task<StockItem> GetStockItemByItemId(Guid id);
        public Task<StockItem> GetStockItemByModel(StockItem stockItem);
        public Task<StockItem> UpdateStockItem(StockItem stockItem);
        //device
        public Task<Device> CreateDevice(Device device);
        public Task DeleteDevice(Guid id);
        public Task<List<Device>> GetAllDevices();
        public Task<Device> GetDeviceById(Guid id);
        public Task<Device> GetDeviceByModel(Device device);
        public Task<List<string>> GetAllDeviceTypes();
    }
}
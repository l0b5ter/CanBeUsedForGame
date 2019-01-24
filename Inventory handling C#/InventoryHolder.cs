public class Gui implements InventoryHolder {
    private Map<Integer, Button> buttons = new HashMap<>();

    public Gui(int size, String title) {
        inventory = Bukkit.createInventory(this, size, title);
    }

    public void addButton(int x, int y, Button button) {
        buttons.put(x + y * 9, button);
    }

    // Call this any time any of your buttons' icons change
    public void render() {
        inventory.clear();

        buttons.forEach((slot, button) -> inventory.setItem(slot, button.getIcon()));
    }

    public void openFor(Player player) {
        // First make sure all icons are in the invnetory
        render();
        player.openInventory(inventory);
    }

    @Override
    public Inventory getInventory() {
        return inventory;
    }

    public void handleClickEvent(InventoryClickEvent e) {
        if (buttons.containsKey(e.getSlot())) {
            buttons.get(e.getSlot()).onClick(e);
        }
    }
}
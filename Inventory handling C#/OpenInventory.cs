public class GuiListener implements Listener {
    @EventHandler
    public void onClick(InventoryClickEvent e) {
        // Always cover all your bases, you never know
        if (e.getInventory() == null || !(e.getInventory().getHolder() instanceof Gui) || !(e.getWhoClicked() instanceof Player)) {
            return;
        }

        ((Gui) e.getInventory().getHolder()).handleClickEvent(e);
    }
}
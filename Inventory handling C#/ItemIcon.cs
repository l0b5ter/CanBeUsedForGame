public abstract class Button {
    private ItemStack icon;

    public Button(ItemStack icon) {
        this.icon = icon;
    }

    public ItemStack getIcon();

    public abstract onClick(InventoryClickEvent e);
}
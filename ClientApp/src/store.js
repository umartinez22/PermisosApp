import { reactive } from 'vue'

export const store = reactive({
    isAddMode: false,
    changeAddMode() {
        this.isAddMode = !this.isAddMode;
    }
})
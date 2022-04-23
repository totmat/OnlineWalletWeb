import { mount } from '@vue/test-utils'
import ViewTest from '@/views/Felhasznalok.vue'

describe('Felhasznalo oldal komponens tesztje', () => {
    test('statiskus tartalom ellenőrzése', () => {
        const wrapper = mount(ViewTest)

        expect(wrapper.text()).toContain('Név')
    })
})


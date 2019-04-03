// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

import { AppPage } from './app.po';

describe('TokenTrackerQuickApp App', () => {
    let page: AppPage;

    beforeEach(() => {
        page = new AppPage();
    });

    it('should display application title: TokenTrackerQuickApp', () => {
        page.navigateTo();
        expect(page.getAppTitle()).toEqual('TokenTrackerQuickApp');
    });
});

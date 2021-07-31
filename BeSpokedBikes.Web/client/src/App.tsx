import React, { Fragment, useContext, useEffect, useState } from "react";
import moment from "moment-timezone";
import { observer } from "mobx-react";
import { Route, RouteComponentProps, Switch, withRouter } from "react-router-dom";
moment.updateLocale("en", {
    week: {
        dow: 0, // First day of week is Sunday
        doy: 6, // First week of year must contain 1 January (7 + 0 - 1)
    },
});
moment.locale("en-US");
moment.tz.setDefault("ETC/Utc");
interface IAppProps extends RouteComponentProps { }
const App: React.FC<IAppProps> = ({ location }) => {
    return (<>
        <Route exact path="/" >
            Welcome
        </Route>
        <Route
            path={"/(.+)"}
            render={({ match }) => {
                return (
                    <div style={{ paddingLeft: 16, paddingRight: 16 }}>

                        {/* <Switch>
                       
                        </Switch> */}
                    </div>)
            }} />
    </>);
}

export default withRouter(observer(App))